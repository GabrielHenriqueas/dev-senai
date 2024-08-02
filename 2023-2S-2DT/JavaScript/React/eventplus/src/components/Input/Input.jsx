import React, { useState } from 'react';

const Input = (props) => {//contrutor
    const [meuValor, setMeuValor] = useState();
    return (
        <div>
            <input
                type={props.tipo}
                id={props.id}
                name={props.nome}
                placeholder={props.dicaCampo}
                value={props.valor}
                onChange={(e) => {
                        // setMeuValor(e.target.value)//valor atual do componente

                        props.fnAltera(e.target.value)//valor do input
                    }}
            />
            <span>{meuValor}</span>
        </div>
    );
};

export default Input;