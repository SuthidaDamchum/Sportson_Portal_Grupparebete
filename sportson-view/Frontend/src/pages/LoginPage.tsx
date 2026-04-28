import { useState, type FormEvent } from 'react';
import { useNavigate } from 'react-router-dom';
import { authService } from '../services/AuthService';
import { useUser } from '../context/UserContext';
import './LoginPage.css';
import TermsPage, { PrivacyPage } from './TermsPage';

const LoginPage = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState('');
  const navigate = useNavigate();
  const { refreshUser } = useUser();
  const [modal, setModal] = useState<'terms' | 'privacy' | null>(null);

  const handleLogin = async (e: FormEvent) => {
    e.preventDefault();
    setError('');
    try {
      await authService.login(username, password);
      await refreshUser();
      navigate('/');
    } catch (err) {
      setError('Felaktigt användarnamn eller lösenord. Försök igen.');
    }
  };

  return (
    <div className="login-page">
      <div className="login-overlay" />
      <div className="login-content">
        <div className="login-left">
          <h1>
            Välkommen till
            <br />
            Sportson Portalen
          </h1>
        </div>
        <div className="login-right">
          <h2>Logga in</h2>
          <form onSubmit={handleLogin} className="login-form">
            <div className="form-group">
              <label>Användarnamn</label>
              <input
                type="text"
                placeholder="Ange ditt användarnamn"
                value={username}
                onChange={(e) => setUsername(e.target.value)}
                required
              />
            </div>
            <div className="form-group">
              <label>Lösenord</label>
              <input
                type="password"
                placeholder="Ange ditt lösenord"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
                required
              />
            </div>
            <button type="submit" className="login-btn">
              Logga in
            </button>
            {error && <p className="error-text">{error}</p>}
            <p className="terms-text">
              Genom att logga in godkänner du våra{' '}
              <button type="button" className="terms-link" onClick={() => setModal('terms')}>
                Användarvillkor
              </button>{' '}
              och vår{' '}
              <button type="button" className="terms-link" onClick={() => setModal('privacy')}>
                Integritetspolicy
              </button>.
            </p>
          </form>
        </div>
      </div>

      {modal && (
        <div className="modal-overlay" onClick={() => setModal(null)}>
          <div className="modal-content" onClick={(e) => e.stopPropagation()}>
            <button className="modal-close" onClick={() => setModal(null)}>✕</button>
            {modal === 'terms' && <TermsPage />}
            {modal === 'privacy' && <PrivacyPage />}
          </div>
        </div>
      )}
    </div>
  );
};

export default LoginPage;