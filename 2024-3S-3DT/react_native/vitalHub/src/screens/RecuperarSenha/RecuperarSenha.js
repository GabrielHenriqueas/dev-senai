import { Button, ButtonTitle } from "../../components/Button/StyledButton"
import { Container } from "../../components/Container/StyledContainer"
import { Input } from "../../components/Input/StyledInput"
import { Logo } from "../../components/Logo/StyledLogo"
import { SubTitle, Title } from "../../components/Title/StyledTitle"

export const RecuperarSenha = ({ navigation }) => {
    return (
        < Container >
            <Logo source={require('../../assets/VitalHubLogo.png')} />

            <Title>Recuperar Senha</Title>

            <SubTitle>Digite abaixo seu email cadastrado que enviaremos um link para recuperação de senha</SubTitle>

            <Input
                placeholder="Usuário ou E-mail"
            />

            <Button onPress={() => navigation.replace("VerificaEmail")}>
                <ButtonTitle>Continuar</ButtonTitle>
            </Button>


        </Container >
    )
}