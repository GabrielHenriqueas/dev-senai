import React, { useContext }from 'react';
import './ImportantePage.css'
import { ThemeContext } from '../../context/ThemeContext';

const ImportantePage = () => {
    const { theme } = useContext(ThemeContext);
    return (
        <div>
            <h1>Importante</h1>
            <span>Tema Atual: {theme}</span>
        </div>
    );
};

export default ImportantePage;