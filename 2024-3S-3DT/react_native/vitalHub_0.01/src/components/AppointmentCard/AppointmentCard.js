import { AntDesign } from '@expo/vector-icons';
import { ButtonCard, ButtonText, ClockCard, ContainerCardList, ContentCard, DataProfileCard, ProfileData, ProfileImage, ProfileName, TextAge, TextBold, ViewRow } from './StyledAppointmentCard';

export const AppointmentCard = ({
    situacao = "pendente",
    onPressCancel,
    onPressVerProntuario,
    onPressAppointment,
}) => {
    return (
        // container principal
        <ContainerCardList>

            {/* imagem perfil */}
            <ProfileImage source={{ uri: "https://github.com/ThiagoRafael-lin.png" }} />

            {/* conteudo do card */}
            <ContentCard>

                <DataProfileCard>
                    <ProfileName>Tinas</ProfileName>

                    <ProfileData>
                        <TextAge>18 Anos</TextAge>
                        <TextBold>Rotina</TextBold>
                    </ProfileData>
                </DataProfileCard>

                <ViewRow>
                    {/* icone + horário */}
                    <ClockCard situacao={situacao}>
                        <AntDesign name="clockcircle" size={14} color={situacao == "pedente" ? "#49B3BA" : "#49B3BA"} />
                        <TextBold >14:00</TextBold>
                    </ClockCard>

                    {/* valida e mostra o tipo de botão conforme a situação da consulta */}

                    {
                        situacao === "cancelado" ? (
                            <>
                            </>
                        ) : situacao == "pendente" ?
                            (
                                <ButtonCard onPress={onPressCancel}>
                                    <ButtonText situacao={situacao}>Cancelar</ButtonText>
                                </ButtonCard>
                            ) : (
                                <ButtonCard onPress={onPressVerProntuario}>
                                    <ButtonText situacao={situacao}>Ver prontuário</ButtonText>
                                </ButtonCard>
                            )
                    }

                </ViewRow>


            </ContentCard>

        </ContainerCardList>
    )
}