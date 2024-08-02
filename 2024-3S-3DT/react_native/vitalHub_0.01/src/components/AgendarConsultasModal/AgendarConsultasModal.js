import { Modal } from "react-native"

export const AgendarConsultasModal = ({
    visible,
    setShowAgendarConsultasModal,
    ...rest
}) => {
    return (
     <Modal {...rest} visible={visible} transparent={transparent} animationType="fade" >

        

     </Modal>   
    )
}