import styled from "styled-components";
import { Container } from "../../components/Container/StyledContainer";
import { Logo } from "../../components/Logo/StyledLogo";
import { SubTitle, Title } from "../../components/Title/StyledTitle";
import { ContentAccount, ContentNumber, LinkBold } from "../../components/ContentAccount/StyledContentAccount";
import { InputVerifica } from "../../components/Input/StyledInput";
import { DefaultButton } from "../../components/Button/Button";
import { Link } from "../../components/Link/Link";

export const VerificaEmail = ({ navigation }) => {
    return (
        <Container>
            <Logo source={require('../../assets/VitalHubLogo.png')} />

            <Title>Verifique seu e-mail</Title>

            <SubTitle>Digite o código de 4 dígitos enviado para      <LinkBold>username@email.com</LinkBold></SubTitle>

            <ContentNumber>
                <InputVerifica
                    placeholder="0"
                    keyboardType={"numeric"}
                    maxLength={1}
                />

                <InputVerifica
                    placeholder="0"
                    keyboardType={"numeric"}
                    maxLength={1}
                />

                <InputVerifica
                    placeholder="0"
                    keyboardType={"numeric"}
                    maxLength={1}
                />

                <InputVerifica
                    placeholder="0"
                    keyboardType={"numeric"}
                    maxLength={1}
                />
            </ContentNumber>

            <DefaultButton text={"Entrar"} onPress={() => navigation.replace("RedefinirSenha")} />

            <Link link={"Reenviar Código"} />
        </Container>
    )
}