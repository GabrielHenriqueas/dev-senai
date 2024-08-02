import styled from "styled-components";

export const Title = styled.Text`
    font-size: 20px;
    font-family: 'MontserratAlternates_600SemiBold';
    color: #33303e;
    margin-top: 25px;
`

export const SubTitle = styled(Title)`
    font-size: 16px;
    font-family: 'Quicksand_500Medium';
    color: #5F5C6B;

    text-align: center;
    width: 90%;
    height: 72px;
`

export const NameText = styled.Text`
    font-size: 20px;
    font-family: 'MontserratAlternates_600SemiBold';
    color: #33303e;
`

export const LinkEmail = styled.Text`
    font-size: 16px;
    font-family: 'Quicksand_500Medium';
    color: #5F5C6B;
    text-align: center;
    width: 90%;
`

export const LabelPerfil = styled.Text`
    width: 90%;
    font-size: 16px;
    font-family: "Quicksand_600SemiBold";
    color: black;
    margin-top: 24px;
`

export const LabelCidadeCep = styled(LabelPerfil)`
    width: 45%;
`