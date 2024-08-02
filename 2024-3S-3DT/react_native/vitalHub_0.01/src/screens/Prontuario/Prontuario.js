import { Button, ButtonGray, ButtonTitle } from "../../components/Button/StyledButton"
import { Container, ContainerImage, ContainerScroll } from "../../components/Container/StyledContainer"
import { LinkBold } from "../../components/ContentAccount/StyledContentAccount"
import { Input, InputProntuario, PerfilInput } from "../../components/Input/StyledInput"
import { PerfilImage } from "../../components/PerfilImage/StyledPacientCard"
import { PerfilRectangle } from "../../components/PerfilRectangle/StyledPerfilRectangle"
import { LabelPerfil, LinkEmail, NameText } from "../../components/Title/StyledTitle"

export const Prontuario = ({ Prontuario }) => {
    return (
        <ContainerScroll>
            <Container>

                <ContainerImage>
                    <PerfilImage source={require('../../assets/PerfilImage.png')} />

                    <PerfilRectangle>
                        <NameText>Richard Kosta</NameText>
                        <LinkEmail>richard.kosta@gmail.com</LinkEmail>
                    </PerfilRectangle>
                </ContainerImage>

                <LabelPerfil>Descrição da Consulta</LabelPerfil>
                <InputProntuario
                    placeholder={"Descrição"}
                />

                <LabelPerfil>Diagnóstico do paciente</LabelPerfil>
                <Input
                    placeholder={"Diagnóstico"}
                />

                <LabelPerfil>Prescrição médica</LabelPerfil>
                <InputProntuario
                    placeholder={"Prescrição"}
                />

                <Button>
                    <ButtonTitle>Salvar</ButtonTitle>
                </Button>

                <ButtonGray>
                    <ButtonTitle>Editar</ButtonTitle>
                </ButtonGray>

                <LinkBold>Cancelar</LinkBold>
            </Container >
        </ContainerScroll>
    )
}