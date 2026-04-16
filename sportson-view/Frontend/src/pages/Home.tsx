import { Swiper, SwiperSlide } from "swiper/react";
import { A11y, Autoplay, Navigation } from "swiper/modules";
import "swiper/swiper-bundle.css";
import doggeImage from "../assets/images/DoggeMedCykel.webp";
import bikersImage from "../assets/images/Bikers.jpg";
import bikeStoreImage from "../assets/images/BikeStore.webp";
import downhillBike from "../assets/images/downhillBike.webp";
import bikeImage from "../assets/images/genericbike.webp";
import "./Home.css";
import ImportantDate from "../pages/ImportantDate";

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
    imageUrl: bikeImage,
  },
  {
    id: 2,
    title: "Dogges cykelkampanj",
    description: "Cykeln på köpet!!!",
    imageUrl: doggeImage,
  },
  {
    id: 3,
    title: "Nyheter",
    description: "Nyheter i butik",
    imageUrl: bikeStoreImage,
  },
  {
    id: 4,
    title: "Downhill cykelkampanj",
    description: "Downhill Bike rea",
    imageUrl: downhillBike,
  },
  {
    id: 5,
    title: "Begränsat erbjudande",
    description: "Vårservice kampanjer",
    imageUrl: bikersImage,
  },
];

const Home = () => {
  return (
    <>
      <section className="home-hero">
        <Swiper
          className="home-hero-swiper"
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
              <article className="home-hero-card">
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
            <div className="layout-wrapper">
                  <div className="right-side-pusher">
                    <ImportantDate />
                  </div>
    </div>
    </>
  );
};

export default Home;
