import styled from "styled-components";

export const Button = styled.TouchableOpacity`
    width: 90%;
    height: 44px;
    border-radius: 5px;
    background-color: #496BBA;
    border: 1px solid #496BBA;
    justify-content: center;
    align-items: center;
    margin-top: 27px;
    padding: 12px 8px 12px 8px;
    margin-bottom: 30px;
`
export const ButtonTitle = styled.Text`
    color: #FFFFFF;
    font-size: 14px;
    font-family: "MontserratAlternates_600SemiBold";
    text-transform: uppercase;
`
export const ButtonGoogle = styled(Button)`
    flex-direction: row;
    gap: 27px;
    background-color: #FAFAFA;
    border: 1px solid #496BBA;
    margin-top: -12px;
`
export const ButtonTitleGoogle = styled(ButtonTitle)`
        color: #496BBA;
`
export const ButtonGray = styled(Button)`
    width: 190px;
    background-color: #ACABB7;
    border-color: #ACABB7;
`