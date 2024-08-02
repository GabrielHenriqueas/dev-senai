import { Button, ButtonTitle } from "../../components/Button/StyledButton"
import { Container, ContainerImage, ContainerScroll } from "../../components/Container/StyledContainer"
import { LinkBold } from "../../components/ContentAccount/StyledContentAccount"
import { Input, InputProntuario, InputProntuarioEdit, PerfilInput } from "../../components/Input/StyledInput"
import { PerfilImage } from "../../components/PerfilImage/StyledPacientCard"
import { PerfilRectangle } from "../../components/PerfilRectangle/StyledPerfilRectangle"
import { LabelPerfil, LinkEmail, NameText } from "../../components/Title/StyledTitle"

export const ProntuarioEdit = ({ ProntuarioEdit }) => {
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
                <InputProntuarioEdit
                    placeholder={"O paciente possuí uma infecção no ouvido. Necessário repouse de 2 dias e acompanhamento médico constante"}
                />
                <LabelPerfil>Diagnóstico do paciente</LabelPerfil>
                <PerfilInput
                    placeholder={"Infecção no ouvido"}
                />

                <LabelPerfil>Prescrição médica</LabelPerfil>
                <InputProntuarioEdit
                    placeholder={"Medicamento: Advil Dosagem: 50 mg Frequência: 3 vezes ao dia Duração: 3 dias"}
                />

                <Button>
                    <ButtonTitle>Salvar</ButtonTitle>
                </Button>

                <Button>
                    <ButtonTitle>Editar</ButtonTitle>
                </Button>

                <LinkBold>Cancelar</LinkBold>
            </Container>
        </ContainerScroll>
    )
}