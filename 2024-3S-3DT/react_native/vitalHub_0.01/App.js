import { NavigationContainer } from "@react-navigation/native";
import { createNativeStackNavigator } from "@react-navigation/native-stack";
import { Navegacao } from "./src/screens/Navegacao/Navegacao";
import { Login } from "./src/screens/Login/Login";
import { useFonts, MontserratAlternates_600SemiBold, MontserratAlternates_500Medium, Quicksand_500Medium, Quicksand_600SemiBold, Quicksand_400Regular } from "@expo-google-fonts/dev";
import { RecuperarSenha } from "./src/screens/RecuperarSenha/RecuperarSenha";
import { VerificaEmail } from "./src/screens/VerificaEmail/VerificaEmail";
import { RedefinirSenha } from "./src/screens/RedefinirSenha/RedefinirSenha";
import { CriarConta } from "./src/screens/CriarConta/CriarConta";
import { Perfil } from "./src/screens/Perfil/Perfil";
import { ConsultasMedico } from "./src/screens/ConsultasMedico/ConsultasMedico";
import { Prontuario } from "./src/screens/Prontuario/Prontuario";
import { ProntuarioEdit } from "./src/screens/ProntuarioEdit/ProntuarioEdit";
import { SelecionarClinica } from "./src/screens/SelecionarClinica/SelecionarClinica";
import { ConsultasPaciente } from "./src/screens/ConsultasPaciente/ConsultasPaciente";
import { Main } from "./src/screens/Main/Main";

const Stack = createNativeStackNavigator();

export default function App() {

  const [fontsLoaded, fontsError] = useFonts({
    MontserratAlternates_600SemiBold,
    MontserratAlternates_500Medium,
    Quicksand_500Medium,
    Quicksand_600SemiBold,
    Quicksand_400Regular,
  })

  if (!fontsLoaded && !fontsError) {
    return null;
  }

  return (
    //Container - envolve toda a estrutura de navegação
    //Navigator - componentes para a navegação
    //Tela - tela
    //name: nome da tela
    //component: componente que será chamado
    //options(title): título da tela

    <NavigationContainer>

      <Stack.Navigator screenOptions={{
        headerShown: false
      }}>
        <Stack.Screen
          name="Navegacao"
          component={Navegacao}
          options={{ title: "Navegação" }}
        />
        <Stack.Screen
          name="Login"
          component={Login}
          options={{ title: "Login" }}
        />
        <Stack.Screen
          name="Main"
          component={Main}
        />


        <Stack.Screen
          name="RecuperarSenha"
          component={RecuperarSenha}
          options={{ title: "Recuperar Senha" }}
        />
        <Stack.Screen
          name="VerificaEmail"
          component={VerificaEmail}
          options={{ title: "Verifique seu email" }}
        />
        <Stack.Screen
          name="RedefinirSenha"
          component={RedefinirSenha}
          options={{ title: "Redefinir Senha" }}
        />
        <Stack.Screen
          name="CriarConta"
          component={CriarConta}
          options={{ title: "CriarConta" }}
        />
        <Stack.Screen
          name="Perfil"
          component={Perfil}
          options={{ title: "Perfil" }}
        />
        <Stack.Screen
          name="ConsultasMedico"
          component={ConsultasMedico}
          options={{ title: "ConsultasMedico" }}
        />
        <Stack.Screen
          name="Prontuario"
          component={Prontuario}
          options={{ title: "Prontuario" }}
        />
        <Stack.Screen
          name="ProntuarioEdit"
          component={ProntuarioEdit}
          options={{ title: "ProntuarioEdit" }}
        />
        <Stack.Screen
          name="SelecionarClinica"
          component={SelecionarClinica}
          options={{ title: "SelecionarClinica" }}
        />
        <Stack.Screen
          name="ConsultasPaciente"
          component={ConsultasPaciente}
          options={{ title: "ConsultasPaciente" }}
        />
      </Stack.Navigator>
    </NavigationContainer>
  );
}