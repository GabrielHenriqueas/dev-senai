import styled from "styled-components";
import { LinearGradient } from "expo-linear-gradient"

export const Container = styled.SafeAreaView`
    flex: 1;
    align-items: center;
    background-color: #fafafa;
`

export const ContainerImage = styled.SafeAreaView`
    width: 100%;
    height: 330;    
    align-items: center;
`

export const ContainerScroll = styled.ScrollView`
    flex: 1;
`

export const ContainerHeader = styled(LinearGradient).attrs({

    colors: ['#60BFC5', '#496BBA'],
    start: {x:-0.05, y:1.08},
    end: {x:1, y:0},

})`

    width: 100%;
    height: 144px;
    border-radius:  0px 0px 15px 15px;
    flex-direction: row;

    padding: 62px 20px 22px 20px;

    align-items: center;

    justify-content: space-between;


    
`

export const BoxUser = styled.View`

    width: 163px;
    height: 60px;
    display: flex;
    align-items: center;
    justify-content: space-around;
    flex-direction: row;
`

export const ImageUser = styled.Image`
    width: 60px;
    height: 60px;

    border-radius: 5px;
    
`

export const DataUser = styled.View`
    
    
`

export const TextDefault = styled.Text`
    font-size: 14px;
    font-family: "Quicksand_600SemiBold";
    
`

export const NameUser = styled.Text`
    color: #fbfbfb;
    font-size: 16px;
    margin-top: 2px;
    font-family: "MontserratAlternates_600SemiBold";
    
`

export const FilterAppointment = styled.View`
    	width: 90%; 
    	margin: 38px;
        flex-direction: row;
        justify-content: space-between;
`
export const FlatContainer = styled.FlatList`
  width: 100%;
`