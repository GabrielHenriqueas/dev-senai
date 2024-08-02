import { useEffect, useState } from 'react';
import { StatusBar, StyleSheet, Text, TouchableOpacity, View, ImageBackground } from 'react-native';
import { BtnFlex, Container } from './src/components/Container/Container';
import { BtnIncrement, BtnDecrement } from './src/components/Button/Button';
import { TitleBtnIncrement, TitleBtnDecrement, Title } from './src/components/Title/Title';
import { Background } from './src/components/Background/Backgound';


export default function App() {

  //Hook de state
  const [count, setCount] = useState(0);

  //Função para incremento
  const increment = () => {
    setCount(count + 1)
  }

  //Função para decremento
  const decrement = () => {
    if(count > 0){      
      setCount(count - 1)
      alert("Não é possível decrementar!")
    }
  }

  useEffect(() => {
    console.warn(`Contador atualizado: ${count}`)
  }, [count])


  return (
    <Container>

      <Background source={{ uri: "https://i.pinimg.com/474x/b7/92/7a/b7927a612c4208f92bbaf93c94597d28.jpg" }}>

      </Background>

      {/* Title */}
      <Title>Contador: {count}</Title>


      <BtnFlex>
        {/* BtnIcrement */}
        <BtnIncrement onPress={increment}>
          {/* TitleBtnIcrement */}
          <TitleBtnIncrement>Incrementar</TitleBtnIncrement>
        </BtnIncrement>

        {/* BtnDecrement */}
        <BtnDecrement onPress={decrement}>
          {/* TitleBtnDecrement */}
          <TitleBtnDecrement>Decrementar</TitleBtnDecrement>
        </BtnDecrement>
      </BtnFlex>


      <StatusBar style="auto" />
    </Container>
  );
}

const styles = StyleSheet.create({

});
