import React, { useContext } from "react";
import { Link } from "react-router-dom";
import "./Nav.css";

import logoMobile from "../../assets/images/logo-white.svg";
import logoDesktop from "../../assets/images/logo-pink.svg";
import { UserContext } from "../../assets/context/AuthContext";

const Nav = ({  exibeNavbar , setExibeNavbar}) => {

  const {userData, setUserData} = useContext(UserContext);

  return (
    <nav className={`navbar ${exibeNavbar ? "exibeNavbar" : ""}`}>
      <span
        className="navbar__close"
        onClick={() => {
          setExibeNavbar(false);
        }}
      >
        x
      </span>

      <Link to="/">
        <img
          src={window.innerWidth >= 992 ? logoDesktop : logoMobile}
          alt="Event Plus logo"
          className="eventlogo__logo-image"
        />
      </Link>

      <div className="navbar__items-box">
        <Link to="/" className="navbar__item">Home</Link>
        {/* <Link to="/tipo-eventos" className="navbar__item">Tipo de eventos</Link>
        <Link to="/eventos" className="navbar__item">Eventos</Link>
        <Link to="/eventos-aluno" className="navbar__item">Eventos Alunos</Link> */}
        {userData.role === "admin" ? (
            <>
              <Link to="/tipo-eventos" className="navbar__item">Tipos Eventos</Link>
              <Link to="/eventos" className="navbar__item">Eventos</Link>
            </>
        ) : (
              userData.role === "Comum" ? (
              
              <Link to="/eventos-alunos" className="navbar__item">Eventos Aluno</Link>

            ) : (null)
        )}
        {/* <Link to="/login" className="navbar__item">Login</Link> */}
        {/* <Link to="/testes" className="navbar__item">Teste</Link> */}
      </div>
    </nav>
  );
};

export default Nav;