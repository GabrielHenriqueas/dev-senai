import { StatusBar } from "expo-status-bar";
import { View, Text, StyleSheet }  from "react-native"

const Person = ({name, age}) => {
    return (
        <View style={styles.container}>
            <Text style={styles.text}>Nome: {name}</Text>
            <Text style={styles.text}>Idade: {age}</Text>
            <StatusBar/>
        </View>
    )
}

const styles = StyleSheet.create({
    container: {
        backgroundColor: "cyan",
        padding: 15,
        margin: 100,
        borderRadius: 50
    },

    text: {
        fontFamily: 'SingleDay_400Regular',
        fontSize: 36
    }
})

export default Person;