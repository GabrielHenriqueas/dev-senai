import React, { useContext } from 'react';
import './MeusPedidosPage.css'
import { ThemeContext } from '../../context/ThemeContext';

const MeusPedidosPage = () => {
    const { theme, produtos } = useContext(ThemeContext);
    return (
        <div>
            <h1>Meus Pedidos</h1>
            <h2>Página Privada</h2>
            <span>Tema Atual: {theme}</span>

            {produtos.map((e) => {             
                return (
                    <>
                    <br />
                    <br />

                    <strong>Id do Produto: </strong> {e.idProduto} | &nbsp;
                    <strong>Produto: </strong> {e.descricao} | &nbsp;
                    <strong>Preço: </strong> {e.preco}

                    </>

                )
            })}
        </div>
    );
};

export default MeusPedidosPage;