import React from "react";
import "./FormComponents.css";

export const Input = ({
  type,
  id,
  value,
  required,
  additionalClass,
  name,
  placeholder,
  manipulationFunction,
}) => {
  return (
    <input
      type={type}
      id={id}
      name={name}
      value={value}
      required={required}
      className={`input-component ${additionalClass}`}
      placeholder={placeholder}
      onChange={manipulationFunction}
      autoComplete="off"
    />
  );
};

export const Button = ({
  textButton,
  id,
  name,
  type,
  additionalClass = "",
  manipulationFunction,
}) => {
  return (
    <button
      type={type}
      name={name}
      id={id}
      className={`button-component ${additionalClass}`}
      onClick={manipulationFunction}
    >
      {textButton}
    </button>
  );
};

export const Select = ({ 
    dados = [],
    id,
    name,
    require,
    additionalClass = "",
    manipulationFunction,
    value,

}) => {
  return (
    <select 
        id={id}
        name={name}
        required={require}
        className={`input-component ${additionalClass}`}
        onChange={manipulationFunction}
        value={value}
    >

      <option value="">Selecione</option>
      {dados.map((e) => {
        return (
          <option key={e.value} value={e.value}>
            {e.text}
          </option>
        );
      })}
    </select>
  );
};
