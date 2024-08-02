import { useEffect, useState } from 'react';
import { StatusBar, StyleSheet, Text, TouchableOpacity, View } from 'react-native';

export default function App() {

  //Hook de state
  const [count, setCount] = useState(0);

  //Função para incremento
  const increment = () => {
    setCount(count + 1)
  }

  //Função para decremento
  const decrement = () => {
    setCount(count - 1)
  }

  useEffect(() => {
    console.warn(`Contador atualizado: ${count}`)
  }, [count])


  return (
    <View style={styles.container}>

      <Text style={styles.text}>Contador: {count}</Text>

      <TouchableOpacity onPress={increment}>
        <Text style={styles.text}>Incrementar</Text>
      </TouchableOpacity>

      <TouchableOpacity onPress={decrement}>
        <Text style={styles.text}>Decrementar</Text>
      </TouchableOpacity>

      <StatusBar style="auto" />
    </View>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#000',
    alignItems: 'center',
    justifyContent: 'center',
  },

  text: {
    color: 'white',
    fontSize: 36,
  },
});
