import { Modal } from "react-native"
import { ModalContent } from "../CancellationModal/StyledCancellationModal"
import { LinkEmail, Title } from "../Title/StyledTitle"
import { Button, ButtonTitle } from "../Button/StyledButton"
import { ConsultModalStyled } from "./StyledConsultModal"
import { ContentAccount, LinkBold } from "../ContentAccount/StyledContentAccount"
import { ModalImage } from "../PerfilImage/StyledPacientCard"

export const ConsultModal = ({
    visible,
    setShowModalConsult,
    ...rest }) => {
    return (
        // 
        <Modal {...rest} visible={visible} transparent={true} animationType="fade">

            {/* Container */}
            <ConsultModalStyled>
                {/* content */}
                <ModalContent>

                    <ModalImage source={{ uri: "https://github.com/ThiagoRafael-lin.png" }} />

                    {/* Title */}
                    <Title>Niccole Sarga</Title>

                    <LinkEmail>22 anos niccole.sarga@gmail.com</LinkEmail>

                    {/* button modal*/}
                    <Button>
                        <ButtonTitle>Inserir Prontuário</ButtonTitle>
                    </Button>

                    {/* button cancel */}
                    <ContentAccount>
                        <LinkBold onPress={() => setShowModalConsult(false)}>Cancelar</LinkBold>
                    </ContentAccount>

                </ModalContent>
            </ConsultModalStyled>
        </Modal>
    )
}