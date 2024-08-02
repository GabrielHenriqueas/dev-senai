import React, { useContext, useEffect, useState } from "react";
import "./HomePage.css";
import MainContent from "../../components/MainContent/MainContent";
import Banner from "../../components/Banner/Banner";
import VisionSection from "../../components/VisionSection/VisionSection";
import ContactSection from "../../components/ContactSection/ContactSection";
import NextEvent from "../../components/NextEvent/NextEvent";
import Container from "../../components/Container/Container";
import Title from "../../components/Title/Title";
import axios from "axios";
import api from "../../Services/Service"
import { UserContext } from "../../assets/context/AuthContext";

const HomePage = () => {

  const {userData} = useContext(UserContext);

  console.log("DADOS GLOBAIS DO USUÁRIO");
  console.log(userData);

  useEffect(() => {
    //chamar a API
    async function getProximosEventos() {
      try {
        const promise = await api.get("/Evento/ListarProximos");

        console.log(promise.data);
        setNextEvents(promise.data);
      } catch (error) {
        alert("Deu ruim na API");
      }
    }
    getProximosEventos();
    console.log("A HOME FOI MONTADA!");
  }, []);

  //fake mock - api mocada
  const [nextEvents, setNextEvents] = useState([
    // {
    //   id: 1,
    //   title: "Evento X",
    //   descricao: "Evento de SQL Server",
    //   data: "10/11/2023",
    // },
    // {
    //   id: 2,
    //   title: "Evento Y",
    //   descricao: "Bora Codar JS",
    //   data: "11/11/2023",
    // }
  ]);

  return (
    <MainContent>
      <Banner />

      {/* PRÓXIMOS EVENTOS */}
      <section className="proximos-eventos">
        <Container>
          <Title titleText={"Próximos Eventos"} />

          <div className="events-box">
            {nextEvents.map((e) => {
              return (
                <NextEvent
                  title={e.nomeEvento}
                  description={e.descricao}
                  eventDate={e.dataEvento}
                  idEvento={e.idEvento}
                />
              );
            })}

          </div>
        </Container>
      </section>

      <VisionSection />
      <ContactSection />
    </MainContent>
  );
};

export default HomePage;
