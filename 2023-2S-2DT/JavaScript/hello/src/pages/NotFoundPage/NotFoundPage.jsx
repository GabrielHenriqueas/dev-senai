import React, { useContext } from 'react';
import { Link } from "react-router-dom"
import './NotFoundPage.css'
import { ThemeContext } from '../../context/ThemeContext';

const NotFoundPage = () => {
    const { theme } = useContext(ThemeContext);
    return (
        <>
            <h1>Página não encontrada</h1>
            <span>Tema Atual: {theme}</span>
            <Link to="/">Home</Link>
        </>
    );
};

export default NotFoundPage;