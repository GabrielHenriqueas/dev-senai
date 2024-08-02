import React, { useContext, useEffect, useState } from "react";
import MainContent from "../../components/MainContent/MainContent";
import Title from "../../components/Title/Title";
import Table from "./TableEvA/TableEvA";
import Container from "../../components/Container/Container";
import { Select } from "../../components/FormComponents/FormComponents"
import Spinner from "../../components/Spinner/Spinner";
import Modal from "../../components/Modal/Modal";
import api from "../../Services/Service";

import "./EventosAlunoPage.css";
import { UserContext } from "../../assets/context/AuthContext";
import { clear } from "@testing-library/user-event/dist/clear";

const EventosAlunoPage = () => {
  // state do menu mobile
  const [exibeNavbar, setExibeNavbar] = useState(false);
  const [eventos, setEventos] = useState([]);
  // select mocado
  const [quaisEventos, setQuaisEventos] = useState([
    { value: "1", text: "Todos os eventos" },
    { value: "2", text: "Meus eventos" },
  ]);

  const [tipoEvento, setTipoEvento] = useState("1"); //código do tipo do Evento escolhido
  const [showSpinner, setShowSpinner] = useState(false);
  const [showModal, setShowModal] = useState(false);

  // recupera os dados globais do usuário
  const { userData, setUserData } = useContext(UserContext);

  useEffect(() => {

    loadEventsType();
  }, [tipoEvento, userData.userId]);

  async function loadEventsType() {
    setShowSpinner(true);
    try {
      if (tipoEvento === "1") {// todos os eventos
        const promise = await api.get("/Evento");
        const promiseEventos = await api.get(`/PresencasEvento/ListarMinhas/${userData.userId}`);

        const dadosMarcados = verificaPresenca(promise.data, promiseEventos.data);
        console.clear();
        console.log("DADOS MARCADOS");
        console.log(dadosMarcados);
        setEventos(promise.data);
        console.log(promise.data);

      } else {// meus eventos
        let arrEventos = [];
        const promiseEventos = await api.get(`/PresencasEvento/ListarMinhas/${userData.userId}`);
        promiseEventos.data.forEach((element) => {
          arrEventos.push({
            ...element.evento,
            situacao: element.situacao,
            isPresencaEvento: element.idPresencaEvento
            
           })
        });
        setEventos(arrEventos);
      }        
      
    } catch (error) {
      console.log("Erro ao carregar os eventos");
      console.log(error);
    }
    setShowSpinner(false);
    
  }


  const verificaPresenca = ( arrAllEvents, eventsUser ) => {

    for (let x = 0; x < arrAllEvents.length; x++) {// para cada evento (todos)
      // verifica se o aluno está participando do evento atual (x)
      for (let i = 0; i < eventsUser.length; i++) {
        if (arrAllEvents[x].idEvento === eventsUser[i].evento.idEvento) {

          arrAllEvents[x].situacao = true;
          arrAllEvents[x].idPresencaEvento = eventsUser[i].idPresencaEvento;
          break;
          
        }        
      }
    }
    // devolve o array modificado
    return arrAllEvents;
  }

  // toggle meus eventos ou todos os eventos
  function myEvents(tpEvent) {
    setTipoEvento(tpEvent);
  }

  async function loadMyComentary(idComentary) {
    return "????";
  }

  const showHideModal = () => {
    setShowModal(showModal ? false : true);
  };

  const commentaryRemove = async () => {
    alert("Remover o comentário");
  };

   async function handleConnect(idEvent, connect = false, idPresencaEvento = null) {
    // conecta o usuário e atualiza a tela
    if (connect === true) {
      try {
        const promise = await api.post("/PresencasEvento", {
          situacao: true,
          idUsuario: userData.userId,
          idEvento: idEvent,
        });

        if (promise.status === 201) {
          loadEventsType();
          alert("Presença confirmada, parabéns");
        }
        
      } catch (error) {
        console.log("Erro ao conectar");
        console.log(error);
      }
      return;
    } else {
      try {
            // unconnect
      console.log("ID DAPRESENÇA DO EVENTO");
      console.log(idPresencaEvento);
  
      const promiseDelete = api.delete("/PresencasEvento/" + idPresencaEvento);
      if (promiseDelete.status ) {
        
      }
  
      alert("Desconectar do evento " + idEvent);
      } catch (error) {
        console.log("Erro ao desconectar");
        console.log(error);
      }

    }


    
  }
  return (
    <>
      {/* <Header exibeNavbar={exibeNavbar} setExibeNavbar={setExibeNavbar} /> */}

      <MainContent>
        <Container>
          <Title titleText={"Eventos"} additionalClass="custom-title" />

          <Select
            id="id-tipo-evento"
            name="tipo-evento"
            required={true}
            dados={quaisEventos} // aqui o array dos tipos
            manipulationFunction={(e) => myEvents(e.target.value)} // aqui só a variável state
            defaultValue={tipoEvento}
            additionalClass="select-tp-evento"
          />
          <Table
            dados={eventos}
            fnConnect={handleConnect}
            fnShowModal={() => {
              showHideModal();
            }}
          />
        </Container>
      </MainContent>

      {/* SPINNER -Feito com position */}
      {showSpinner ? <Spinner /> : null}

      {showModal ? (
        <Modal
          userId={userData.userId}
          showHideModal={showHideModal}
          fnGet={loadMyComentary}
          fnPost={postMyComentary}
          fnDelete={commentaryRemove}
        />
      ) : null}
    </>
  );
};

export default EventosAlunoPage;
