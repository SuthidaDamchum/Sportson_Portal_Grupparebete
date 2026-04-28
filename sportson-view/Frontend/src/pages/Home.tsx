import { Swiper, SwiperSlide } from "swiper/react";
import { A11y, Autoplay, Navigation } from "swiper/modules";
import "swiper/swiper-bundle.css";
import doggeImage from "../assets/images/DoggeMedCykel.webp";
import bikersImage from "../assets/images/Bikers.jpg";
import bikeStoreImage from "../assets/images/BikeStore.webp";
import downhillBike from "../assets/images/downhillBike.webp";
import bikeImage from "../assets/images/MountainBikeImage.jpg";
import "./Home.css";
import ImportantDate from "../pages/ImportantDate";
import HomeArticles from "../pages/HomeArticles";
import { useUser } from "../context/UserContext";

//Temporär mockdata!

type HeroSlide = {
  id: number;
  title: string;
  description: string;
  imageUrl: string;
};

const heroSlides: HeroSlide[] = [
  {
    id: 1,
    title: "Kampanj",
    description: "Mountain bike rea",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonheroslider/Bikers.jpg",
  },
  {
    id: 2,
    title: "Dogge Doggelitos vårkampanj",
    description: "Cykeln på köpet!",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonheroslider/DoggeMedCykel.webp",
  },
  {
    id: 3,
    title: "Nyheter",
    description: "Nyheter i butik",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonheroslider/BikeStore.webp",
  },
  {
    id: 4,
    title: "Kampanj",
    description: "Downhill Bike rea",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonheroslider/downhillBike.webp",
  },
  {
    id: 5,
    title: "Begränsat erbjudande",
    description: "Vårservice kampanjer",
    imageUrl:
      "https://sportsonnews.blob.core.windows.net/sportsonheroslider/Bikers.jpg",
  },
];

const Home = () => {
  const { user } = useUser();

  if (!user) return null;
  return (
    <>
      <section className="home-hero" id="home-hero-section">
        <Swiper
          className="home-hero-swiper"
          id="home-hero-swiper"
          modules={[Navigation, Autoplay, A11y]}
          navigation
          loop
          centeredSlides
          slidesPerView={1.2}
          spaceBetween={20}
          autoplay={{
            delay: 4500,
            disableOnInteraction: false,
          }}
          breakpoints={{
            768: { slidesPerView: 1.65, spaceBetween: 24 },
            1200: { slidesPerView: 2.15, spaceBetween: 30 },
          }}
        >
          {heroSlides.map((slide) => (
            <SwiperSlide key={slide.id}>
              <article
                className="home-hero-card"
                id={`home-hero-slide-${slide.id}`}
              >
                <img className="home-hero-image" src={slide.imageUrl} />
                <div className="home-hero-overlay" />
                <div className="home-hero-content">
                  <h2 className="home-hero-title">{slide.title}</h2>
                  <p className="home-hero-description">{slide.description}</p>
                </div>
              </article>
            </SwiperSlide>
          ))}
        </Swiper>
      </section>

      <div className="home-bottom">
        <HomeArticles />
        <ImportantDate />
      </div>
    </>
  );
};

export default Home;
