
import { FlatList, SafeAreaView, StatusBar, StyleSheet, Text, View } from 'react-native';
import Person from "./src/components/Person/Person"

import { useFonts, Poppins_300Light } from '@expo-google-fonts/poppins';
import { SingleDay_400Regular } from '@expo-google-fonts/single-day';

import Jogos from './src/components/Jogos/Jogos';

export default function App() {

  let [fontsLoaded, fontError] = useFonts({
    Poppins_300Light,
    SingleDay_400Regular
  });

  const peopleList = [
    {id: "1", name: "Catarina", age: "16"},
    {id: "2", name: "Matheus", age: "16"},
    {id: "3", name: "Vinicius", age: "20"}
  ]

  const gamesList = [
    {id: "1", name: "RDR2", genero: "Foroeste", lancamento: "20.10.2020"},
    {id: "2", name: "CupHead", genero: "Alguma coisa", lancamento: "20.10.2017"},
    {id: "3", name: "FIFA23", genero: "Futebol", lancamento: "20.10.2022"},
  ]

  return (
    <SafeAreaView>

      {/* FlatList */}
      <FlatList
      
        data={peopleList}
        keyExtractor={(item) => item.id}
        renderItem={({ item }) => <Person name={item.name} age={item.age} /> }
      
      />
      <FlatList
      
        data={gamesList}
        keyExtractor={(item) => item.id}
        renderItem={({ item }) => <Jogos name={item.name} genero={item.genero}  lancamento={item.lancamento}/> }
      
      />

      <StatusBar style="auto" />
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});
