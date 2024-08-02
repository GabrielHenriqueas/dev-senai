import React, { useState } from "react";
import { Route, BrowserRouter, Routes } from "react-router-dom";

// Imports dos componentes - PÁGINAS
import HomePage from "./pages/HomePage/HomePage";
import LoginPage from "./pages/LoginPage/LoginPage";
import ProdutoPage from "./pages/ProdutoPage/ProdutoPage";
import NotFoundPage from "./pages/NotFoundPage/NotFoundPage";
import MeusPedidosPage from "./pages/MeusPedidosPage/MeusPedidosPage"
import ImportantePage from "./pages/ImportantePage/ImportantePage"
import Nav from "./components/Nav/Nav"

// representa o objeto do contexto de tema
import { ThemeContext } from "./context/ThemeContext";

// Tester as Rotas
// Context API
// Token
// Login em si

const Rotas = () => {
  
  return (
    <BrowserRouter>
        <Nav />
          <Routes>
            <Route element={ <HomePage /> }  path={"/"} exact />
            <Route element={ <ProdutoPage /> }  path={"/produtos"} />
            <Route element={ <ImportantePage /> }  path={"/importante"} />
            <Route element={ <MeusPedidosPage /> }  path={"/meus-pedidos"} />
            <Route element={ <LoginPage /> }  path={"/login"}  />
            <Route element={ <NotFoundPage /> }  path={"*"}  />
          </Routes>
    </BrowserRouter>
  );
};

export default Rotas;
