import Title from "./components/Title/Title";
import CardEvento from "./components/CardEvento/CardEvento";

import Container from "./components/Container/Container";

import "./App.css";
import Contador from "./components/Contador/Contador";
import Rotas from "./routes";
import { ThemeContext } from "./context/ThemeContext";
import { useEffect, useState } from "react";

function App() {
  const [theme, setTheme] = useState("light");
  const pessoa = "José";
  const produtos = [
    {
      idProduto: Math.random(),
      descricao: "Camiseta Regata",
      preco: 49.99,
      promo: false,
    },

    {
      idProduto: Math.random(),
      descricao: "Blusa Moletom",
      preco: 119.89,
      promo: true,
    },

    {
      idProduto: Math.random(),
      descricao: "Camiseta Regata",
      preco: 49.99,
      promo: false,
    },
  ];

  useEffect(() => {

    const tm = localStorage.getItem("theme");

    tm !== null ? setTheme(tm) : setTheme("light")

  }, []);

  // Criar as propriedades titulo, texto, textoLink
  // passar as propriedades em cada um dos 3 componentes abaixo.
  return (
    <ThemeContext.Provider value={{ theme, setTheme, pessoa, produtos }}>
      <div className={`App ${theme === 'dark' ? 'App-dark' : ''}`}>
        <Rotas />
      </div>
    </ThemeContext.Provider>
  );
}

export default App;
