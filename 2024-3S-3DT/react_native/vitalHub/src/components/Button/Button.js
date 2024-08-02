import { Button, ButtonGoogle, ButtonTitle, ButtonTitleGoogle } from "./StyledButton"
import { AntDesign } from '@expo/vector-icons';

export const DefaultButton = ({
    text,
    onPress,
}) => {
    return (
        <Button onPress={onPress}>
            <ButtonTitle>{text}</ButtonTitle>
        </Button>
    )
}

export const GoogleButton = ({
    text,
    onPress
}) => {
    return(
        <ButtonGoogle onPress={onPress}>
            <AntDesign name="google" size={18} color="#496BBA" />
            <ButtonTitleGoogle>{text}</ButtonTitleGoogle>
        </ButtonGoogle>
    )
}