import { Modal } from "react-native"
import { Title } from "../Title/StyledTitle"
import { ModalContent, ModalText, PatientModal } from "./StyledCancellationModal"
import { Button, ButtonTitle } from "../Button/StyledButton"
import { ContentAccount, LinkBold } from "../ContentAccount/StyledContentAccount"

export const CancellationModal = ({
    visible,
    setShowModalCancel,
    ...rest
}) => {
    return (
        // 
        <Modal {...rest} visible={visible} transparent={true} animationType="fade">

            {/* Container */}
            <PatientModal>
                {/* content */}
                <ModalContent>

                    {/* Title */}
                    <Title>Cancelar Consulta</Title>

                    {/* description */}
                    <ModalText>
                        Ao cancelar essa consulta, abrirá uma possível disponibilidade no seu horário, deseja mesmo cancelar essa consulta?
                    </ModalText>

                    {/* button modal*/}
                    <Button>
                        <ButtonTitle>Confirmar</ButtonTitle>
                    </Button>

                    {/* button cancel */}
                    <ContentAccount>
                        <LinkBold onPress={() => setShowModalCancel(false)}>Cancelar</LinkBold>
                    </ContentAccount>


                </ModalContent>
            </PatientModal>
        </Modal>
    )
}