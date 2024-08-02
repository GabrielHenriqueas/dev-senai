import React, { useContext } from 'react';
import { Link } from 'react-router-dom';
import { ThemeContext } from '../../context/ThemeContext';

const Nav = () => {

    const {theme, setTheme} = useContext(ThemeContext);

    function alterarTema() {
        
        const tm = theme === 'light' ? 'dark' : 'light';
        setTheme( tm );
        localStorage.setItem("theme", tm)
        
    }
 
    return (
        <div>
            <Link to="/">Home</Link> | &nbsp;
            <Link to="/produtos">Produtos</Link> | &nbsp;
            <Link to="/importante">Importante</Link> | &nbsp;
            <Link to="/meus-pedidos">Meus Pedidos</Link> | &nbsp;
            <Link to="/login">Login</Link> | &nbsp;
            <button onClick={alterarTema}>{theme}</button>
        </div>
    );
};

export default Nav;