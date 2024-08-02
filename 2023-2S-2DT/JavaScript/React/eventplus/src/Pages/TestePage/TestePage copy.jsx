import React, { useState } from 'react';
import Input from '../../components/Input/Input';
import Button from '../../components/Button/Button';
import Header from '../../components/Header/Header';

const TestePage = () => {
    const [total, setTotal] = useState();
    const [n1, setN1] = useState();
    const [n2, setN2] = useState();

    function handleCalcular(e) {//chamar no submit do form
        e.preventDefault();
        setTotal(parseFloat(n1) + parseFloat(n2));        
    }
    return (
        <form onSubmit={handleCalcular}>

            <Input 
                tipo="number"
                id="numero1"
                nome="numero1"
                dicaCampo="Primeiro Número"
                valor={n1}
                fnAltera={setN1}
            />
            <Input 
                tipo="number"
                id="numero2"
                nome="numero2"
                dicaCampo="Segundo Número"
                valor={n2}
                fnAltera={setN2}
            />

            <Button 
                tipo="submit"
                textoBotao="Somar"
            />
            <p>Resultado: <strong>{total}</strong></p>
        </form>
    );
};

export default TestePage;