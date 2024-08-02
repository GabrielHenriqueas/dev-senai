import { Button, ButtonTitle } from "../../components/Button/StyledButton"
import { Container } from "../../components/Container/StyledContainer"
import { LinkBold } from "../../components/ContentAccount/StyledContentAccount"
import { Input } from "../../components/Input/StyledInput"
import { LinkMedium } from "../../components/Link/StyledLink"
import { Logo } from "../../components/Logo/StyledLogo"
import { SubTitle, Title } from "../../components/Title/StyledTitle"

export const CriarConta = ({ navigation }) => {
    return (
        <Container>
            <Logo source={require('../../assets/VitalHubLogo.png')} />

            <Title>Criar conta</Title>

            <SubTitle>Insira seu endereço de e-mail e senha para realizar seu cadastro.</SubTitle>

            <Input
                placeholder={"Usuário ou E-mail"}
            />
            <Input
                placeholder={"Senha"}
            />
            <Input
                placeholder={"Confirmar Senha"}
            />

            <Button onPress={() => navigation.replace("Login")}>
                <ButtonTitle>CADASTRAR</ButtonTitle>
            </Button>

            <LinkBold>Cancelar</LinkBold>
        </Container>
    )
}