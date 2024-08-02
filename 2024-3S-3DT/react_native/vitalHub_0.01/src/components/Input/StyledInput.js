import styled from "styled-components";

export const Input = styled.TextInput.attrs({
    placeholderTextColor: "#34898f"
})`
    width: 90%;
    height: 53px;
    padding: 16px;
    margin-top: 15px;

    border: 2px solid #49B3BA;
    border-radius: 5px;

    font-size: 16px;
    font-family: "MontserratAlternates_600SemiBold";
    color: #34898f;
`
export const InputProntuario = styled(Input)`
    height: 120px;
`
export const PerfilInput = styled.TextInput.attrs({
    placeholderTextColor: "#33303E"
})`
    width: 90%;
    height: 53px;
    padding: 16px;
    margin-top: 15px;

    border-radius: 5px;

    font-size: 16px;
    font-family: "Quicksand_600SemiBold";
    background-color: #F5F3F3;
`
export const InputProntuarioEdit = styled(PerfilInput)`
    height: 121px;
    
`
export const CepCidadeInput = styled(PerfilInput)`
    width: 45%;
`
export const InputVerifica = styled(Input)`
    width: 65px;
    height: 62px;
    padding: 0px;
    padding-bottom: 5px;
    justify-content: center;
    align-items: center;
    margin-top: 0px;
    font-size: 40px;
    font-family: "Quicksand_600SemiBold";
    text-align: center;
`
export const BoxInput = styled.SafeAreaView`
    width: 90%;
    flex-direction: row;
    justify-content: space-between;
`