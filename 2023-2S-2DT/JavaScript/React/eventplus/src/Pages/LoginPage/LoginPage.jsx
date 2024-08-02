import React, { useContext, useEffect, useState } from "react";
import ImageIllustrator from "../../components/ImageIllustrator/ImageIllustrator";
import logo from "../../assets/images/logo-pink.svg";
import { Input, Button } from "../../components/FormComponents/FormComponents";

import "./LoginPage.css";

import loginImage from "../../assets/images/login.svg";

import api from "../../Services/Service";
import { UserContext, userDecodeToken } from "../../assets/context/AuthContext";
import { useNavigate } from "react-router-dom";

const LoginPage = () => {
  const [user, setUser] = useState({
    email: "gabriel@email.com",
    senha: "Senai@134",
  });
  //fa
  const { userData, setUserData } = useContext(UserContext);
  const navigate = useNavigate();

  useEffect(() => {
    if (userData.name) navigate("/");
  }, []);

  async function handleSubmit(e) {
    e.preventDefault();

    if (user.email.length >= 3 && user.senha.length > 3) {
      //chamar a API
      try {
        const promise = await api.post("/Login", {
          email: user.email,
          senha: user.senha,
        });

        console.log(promise.data.token);

        const userFullToken = userDecodeToken(promise.data.token);

        setUserData(userFullToken); // guarda os dados decodificados (payload)
        localStorage.setItem("token", JSON.stringify(userFullToken));
        navigate("/"); // manda o usuário para a home

        console.log("DADOS DO USUÁRIO");
        console.log(userData);
      } catch (error) {
        // 401 bad request
        alert("Usuários inválidos ou conexão com a internet interrompida");
      }

      alert("Postando os dados na API");
    } else {
      alert("Preencha os campos corretamnete");
    }
  }

  return (
    <div className="layout-grid-login">
      <div className="login">
        <div className="login__illustration">
          <div className="login__illustration-rotate"></div>
          <ImageIllustrator
            imageRender={loginImage}
            altText="Imagem de um homem em frente de uma porta de entrada"
            additionalClass="login-illustrator "
          />
        </div>

        <div className="frm-login">
          <img src={logo} className="frm-login__logo" alt="" />

          <form className="frm-login__formbox" onSubmit={handleSubmit}>
            <Input
              additionalClass="frm-login__entry"
              type="email"
              id="login"
              name="login"
              required={true}
              value={user.email}
              manipulationFunction={(e) => {
                setUser({
                  ...user,
                  email: e.target.value.trim(),
                });
              }}
              placeholder="UserName"
            />
            <Input
              additionalClass="frm-login__entry"
              type="password"
              id="senha"
              name="senha"
              required={true}
              value={user.senha}
              manipulationFunction={(e) => {
                setUser({
                  ...user,
                  senha: e.target.value.trim(),
                });
              }}
              placeholder="Senha"
            />

            <a href="" className="frm-login__link">
              Esqueceu a senha?
            </a>

            <Button
              textButton="Login"
              id="btn-login"
              name="btn-login"
              type="submit"
              additionalClass="frm-login__button"
              onClick={() => {}}
            />
          </form>
        </div>
      </div>
    </div>
  );
};

export default LoginPage;
