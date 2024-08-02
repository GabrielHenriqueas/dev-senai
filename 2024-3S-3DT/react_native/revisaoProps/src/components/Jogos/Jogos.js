import { StatusBar } from "expo-status-bar";
import { View, Text, StyleSheet }  from "react-native"

const Jogos = ({name, genero, lancamento}) => {
    return (
        <View style={styles.container}>
            <Text style={styles.text}>Nome: {name}</Text>
            <Text style={styles.text}>Gênero: {genero}</Text>
            <Text style={styles.text}>Lançamento: {lancamento}</Text>
            <StatusBar/>
        </View>
    )
}

const styles = StyleSheet.create({
    container: {
        backgroundColor: "pink",
        padding: 15,
        margin: 100,
        borderRadius: 10
    },

    text: {
        fontFamily: 'Poppins_300Light',
        fontSize: 36
    }
})

export default Jogos;