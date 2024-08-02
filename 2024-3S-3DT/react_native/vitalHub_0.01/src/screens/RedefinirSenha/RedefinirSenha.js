import { Button, ButtonTitle } from "../../components/Button/StyledButton"
import { Container } from "../../components/Container/StyledContainer"
import { Input } from "../../components/Input/StyledInput"
import { Logo } from "../../components/Logo/StyledLogo"
import { SubTitle, Title } from "../../components/Title/StyledTitle"

export const RedefinirSenha = ({ navigation }) => {
    return (
        <Container>

            <Logo source={require('../../assets/VitalHubLogo.png')} />

            <Title>Redefinir senha</Title>

            <SubTitle>Insira e confirme a sua nova senha</SubTitle>

            <Input
                placeholder={"Nova Senha"} 
            />

            <Input
                placeholder={"Confirmar nova senha"} 
            />

            <Button onPress={() => navigation.replace("Login")}>
                <ButtonTitle>CONFIRMAR NOVA SENHA</ButtonTitle>
            </Button>


        </Container>
    )
}