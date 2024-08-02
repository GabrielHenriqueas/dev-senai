import React from 'react';
import './Footer.css';

const Footer = ( {textRigths = "Escola SENAI de Informática - 2 0 2 3"} ) => {
    return (
        <footer className='footer-page'>
            <p className='footer-page__rights'>{textRigths}</p>
        </footer>
    );
};

export default Footer;