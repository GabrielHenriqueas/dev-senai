import { DefaultButton, GoogleButton } from "../../components/Button/Button"
import { Container } from "../../components/Container/StyledContainer"
import { ContentAccount, LinkBold, TextAccount } from "../../components/ContentAccount/StyledContentAccount"
import { Input } from "../../components/Input/StyledInput"
import { Link } from "../../components/Link/Link"
import { LinkMedium } from "../../components/Link/StyledLink"
import { Logo } from "../../components/Logo/StyledLogo"
import { Title } from "../../components/Title/StyledTitle"

export const Login = ({ navigation }) => {

    async function Login() {
        navigation.navigate("Main")
    }

    return (
        <Container>

            <Logo source={require('../../assets/VitalHubLogo.png')} />

            <Title>Entrar ou criar conta</Title>

            <Input placeholder="Usuário ou E-mail" />

            <Input placeholder="Senha" />

            <LinkMedium onPress={() => navigation.replace("RecuperarSenha")}>Esqueceu sua senha?</LinkMedium>

            <DefaultButton text={"Entrar"} onPress={(e) => Login()} />

            <GoogleButton text={"Entrar com o Google"} />

            {/* <Link text={"Não tem conta?"} link={" Crie uma agora!"} /> */}

            <ContentAccount>
                <TextAccount>Não tem conta?</TextAccount><LinkBold onPress={() => navigation.replace("CriarConta")}> Crie uma agora!</LinkBold>
            </ContentAccount>

        </Container>
    )
}