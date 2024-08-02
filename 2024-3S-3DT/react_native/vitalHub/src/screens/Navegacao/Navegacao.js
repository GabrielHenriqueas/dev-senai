import { Button, View } from "react-native"

export const Navegacao = ({ navigation }) => {
    return (
        <View>
            <Button
                title="Login"
                onPress={() => navigation.navigate("Login")}
            />
            <Button
                title="Recuperar Senha"
                onPress={() => navigation.navigate("RecuperarSenha")}
            />
            <Button
                title="Verifique seu email"
                onPress={() => navigation.navigate("VerificaEmail")}
            />
            <Button
                title="Redefinir Senha"
                onPress={() => navigation.navigate("RedefinirSenha")}
            />
            <Button
                title="Criar Conta"
                onPress={() => navigation.navigate("CriarConta")}
            />
            <Button
                title="Perfil"
                onPress={() => navigation.navigate("Perfil")}
            />
            <Button
                title="Consultas Médico"
                onPress={() => navigation.navigate("ConsultasMedico")}
            />
            <Button
                title="Prontuário"
                onPress={() => navigation.navigate("Prontuario")}
            />
            <Button
                title="ProntuarioEdit"
                onPress={() => navigation.navigate("ProntuarioEdit")}
            />
            <Button
                title="SelecionarClinica"
                onPress={() => navigation.navigate("SelecionarClinica")}
            />
            <Button
                title="Consultas Paciente"
                onPress={() => navigation.navigate("ConsultasPaciente")}
            />
        </View>
    )
}