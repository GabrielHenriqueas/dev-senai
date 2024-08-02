import styled from "styled-components";

export const BtnIncrement = styled.TouchableOpacity`
    width: 200;
    height: 50;
    align-items: center;
    justify-content: center;
    background-color: blue;
    border-color: azure;
    border-width: 2;
    border-radius: 10px;
    margin-top: 50;

`


export const BtnDecrement = styled(BtnIncrement)`
    background-color: red;
    border-color: pink;
`