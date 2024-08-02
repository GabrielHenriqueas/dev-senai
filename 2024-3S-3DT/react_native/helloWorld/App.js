import { StatusBar } from 'expo-status-bar';
import { StyleSheet, Text, TextInput, Touchable, View, } from 'react-native';
import { Button, Image, TouchableOpacity } from 'react-native-web';
import { useFonts, Poppins_800ExtraBold } from '@expo-google-fonts/poppins';

export default function App() {

  let [fontsLoaded, fontError] = useFonts({
    Poppins_800ExtraBold,
  });

  const onPress = () => {
    alert("LOGIN REALIZADO COM SUCESSO!!!");
  }

  return (
    <View style={styles.container}>

      <Image
        style={styles.tinyLogo}
        source={{
          uri: 'https://img.quizur.com/f/img65124d663b4199.85176466.jpeg?lastEdited=1695698306',
        }}
      />

      {/* <Image
        style={styles.tinyLogo}
        source={require('./assets/snpfc-removebg-preview.png')}
      /> */}

      <Text style={styles.texto}>LOGIN</Text>

      <TextInput
        style={styles.input}
        placeholder='Email'
        placeholderTextColor={'black'}
      />

      <TextInput
        style={styles.input}
        placeholder='Senha'
        placeholderTextColor={'black'}
      />

      <TouchableOpacity style={styles.btn} onPress={onPress}>
        <Text style={styles.textButton}>Entrar</Text>
      </TouchableOpacity>

      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: 'black',
    alignItems: 'center',
    justifyContent: 'center',
    gap: 10,
  },

  texto: {
    color: "white",
    fontWeight: '700',
    fontSize: 24,
    marginTop: 75,
    fontFamily: 'Poppins_800ExtraBold', 
    fontSize: 40
  },

  input: {
    width: '90%',
    height: 40,
    backgroundColor: 'white',
    borderWidth: 3,
    padding: 10,
    marginTop: 50,
    borderRadius: 10,
    borderColor: 'blue',
    color: 'black'

  },

  tinyLogo: {
    width: 200,
    height: 200,
    borderRadius: '50%'
  },

  btn: {
    width: '25%',
    height: 40,
    borderColor: 'blue',
    borderWidth: 3,
    justifyContent: 'center',
    alignItems: 'center',
    backgroundColor: 'white',
    borderRadius: 10,
    marginTop: 50,
  },

  textButton: {
    color: 'black',
    textTransform: 'uppercase',
    fontSize: 18,
    fontWeight: 'bold'
    
  },
});
