import { useEffect, useState } from "react";
import { BoxInput } from "../../components/BoxInput";
import { ContainerEstado, ContainerForm, ContainerInput, ContainerUf, ScrollForm } from "./style";
import axios from "axios";

export function Home() {
  //states - variaveis
  const [cep, setCep] = useState();
  const [endereco, setEndereco] = useState({})
  const [estado, setEstado] = useState()

  function Limpar() {
    //Limpa valores do formulário de cep.
    setCep()
    setEndereco()
  }

  async function ChamarCep(cep) {
    try {
      if (cep != "" && cep.length === 8) {

        const response = await (axios.get(`https://viacep.com.br/ws/${cep}/json/`))
        setEndereco(response.data)

        const estado = await axios.get(`https://servicodados.ibge.gov.br/api/v1/localidades/estados/${response.data.uf}`)
        setEstado(estado.data.nome);
      }
    }

    catch (error) {
      console.log(`Erro ao buscar o cep: ${error}`)
    }
  }

  // //states - vaiáveis
  // const [cep, setCep] = useState();
  // const [logradouro, setLogradouro] = useState();
  // const [bairro, setBairro] = useState();
  // const [cep, setCep] = useState();
  // const [cep, setCep] = useState();
  // const [cep, setCep] = useState();

  return (
    <ScrollForm>
      <ContainerForm>
        <BoxInput
          textLabel='informar CEP'
          placeholder='Cep...'
          editable={true}
          keyType='numeric'
          maxLength={8}
          fieldValue={cep}
          onChangeText={(tx) => { setCep(tx) }}
          onBlur={cep ? ChamarCep(cep) : Limpar()}
        />
        <BoxInput
          textLabel='Logradouro'
          placeholder='Logradouro...'
          editable={false}
          fieldValue={endereco.logradouro}
        />
        <BoxInput
          textLabel='Bairro'
          placeholder='Bairro...'
          editable={false}
          fieldValue={endereco.bairro}
        />
        <BoxInput
          textLabel='Cidade'
          placeholder='Cidade...'
          editable={false}
          fieldValue={endereco.localidade}

        />

        <ContainerInput>

          <ContainerEstado>

            <BoxInput
              textLabel='Estado'
              placeholder='Estado...'
              editable={false}
              maxLength={9}
              fieldValue={estado}
            />

          </ContainerEstado>

          <ContainerUf>

            <BoxInput
              textLabel='UF'
              placeholder='UF...'
              editable={false}
              maxLength={9}
              fieldValue={endereco.uf}
            />

          </ContainerUf>

        </ContainerInput>

      </ContainerForm>
    </ScrollForm>
  );
}