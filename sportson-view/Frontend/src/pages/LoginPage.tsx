import { useState, type FormEvent } from 'react';
import { useNavigate } from 'react-router-dom';
import { FaFacebookF, FaTwitter, FaInstagram, FaYoutube } from 'react-icons/fa';
import { authService } from '../services/AuthService';
import { useUser } from '../context/UserContext';
import './LoginPage.css';

const LoginPage = () => {
  const [username, setUsername] = useState('');
  const [password, setPassword] = useState('');
  const [rememberMe, setRememberMe] = useState(false);
  const [error, setError] = useState('');
  const navigate = useNavigate();
  const { refreshUser } = useUser();

  const handleLogin = async (e: FormEvent) => {
    e.preventDefault();
    setError('');

    try {
      await authService.login(username, password);
      await refreshUser();
      navigate('/');
    } catch (err) {
      setError('Invalid credentials');
    }
  };

  return (
    <div className="login-page">
      <div className="login-overlay" />

      <div className="login-content">
        <div className="login-left">
          <h1>
            Welcome
            <br />
            Back
          </h1>

          <p>
            Sign in to continue and access your portal. Enter your credentials
            to get started.
          </p>

          <div className="social-icons">
            <button type="button" aria-label="Facebook">
              <FaFacebookF />
            </button>
            <button type="button" aria-label="Twitter">
              <FaTwitter />
            </button>
            <button type="button" aria-label="Instagram">
              <FaInstagram />
            </button>
            <button type="button" aria-label="YouTube">
              <FaYoutube />
            </button>
          </div>
        </div>

        <div className="login-right">
          <h2>Sign in</h2>

          <form onSubmit={handleLogin} className="login-form">
            <div className="form-group">
              <label>Username</label>
              <input
                type="text"
                placeholder="Enter your username"
                value={username}
                onChange={(e) => setUsername(e.target.value)}
                required
              />
            </div>

            <div className="form-group">
              <label>Password</label>
              <input
                type="password"
                placeholder="Enter your password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
                required
              />
            </div>

            <div className="login-options">
              <label className="remember-me">
                <input
                  type="checkbox"
                  checked={rememberMe}
                  onChange={(e) => setRememberMe(e.target.checked)}
                />
                <span>Remember Me</span>
              </label>
            </div>

            <button type="submit" className="login-btn">
              Sign in now
            </button>

            {error && <p className="error-text">{error}</p>}

            <a href="#" className="forgot-password">
              Lost your password?
            </a>

            <p className="terms-text">
              By clicking on "Sign in now" you agree to
              <br />
              <a href="#">Terms of Service</a> | <a href="#">Privacy Policy</a>
            </p>
          </form>
        </div>
      </div>
    </div>
  );
};

export default LoginPage;