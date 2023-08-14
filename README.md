# Sistema de Gerenciamento de Fichas Médicas

## Introdução

Este é um projeto desenvolvido para atender às necessidades do nosso cliente, um grande hospital, que deseja modernizar o gerenciamento de fichas médicas de seus pacientes. O sistema foi projetado para proporcionar uma experiência segura, eficiente e acessível para médicos, pacientes e profissionais de saúde, permitindo a criação, edição e exclusão de fichas médicas, além de garantir a privacidade das informações clínicas.

## Requisitos do Projeto

- **Backend ASP.NET Core com EF Core:** O sistema utiliza a tecnologia ASP.NET Core para lidar com a lógica de negócios e persistência de dados, oferecendo um ambiente robusto e escalável.

- **Frontend Monólito (Razor/Blazor):** O frontend é desenvolvido como um monólito, utilizando as tecnologias Razor/Blazor para criar interfaces de usuário interativas e responsivas.

- **Testes Unitários:** A qualidade do código é assegurada por meio da implementação de testes unitários, que previnem regressões e garantem o funcionamento correto das funcionalidades.

- **Sistema de Autenticação:** O sistema conta com um sistema de autenticação que permite aos usuários realizar login e registro. Cada usuário é associado a um "role" específico, que determina se são pacientes ou médicos.

- **Acesso Diferenciado para Usuários:** Pacientes têm acesso apenas às suas próprias fichas médicas, enquanto médicos têm permissões para criar, editar e apagar fichas de pacientes.

- **Campos das Fichas Médicas:** As fichas médicas possuem os seguintes campos:
  - Nome completo do paciente.
  - Foto para identificação visual (com suporte a upload de imagens).
  - CPF validado utilizando Expressões Regulares para garantir a formatação correta.
  - Número de celular no formato E.164 para normalização.
  - Endereço opcional para fornecer informações adicionais.

## Instalação e Configuração

1. Clone este repositório para sua máquina local.
2. Navegue para o diretório do projeto do backend (`/backend`) e configure as conexões de banco de dados no arquivo `appsettings.json`.
3. Abra o Visual Studio e execute as migrações para criar o banco de dados com o comando `Update-Database` no console do Gerenciador de Pacotes.
4. Navegue para o diretório do projeto do frontend (`/frontend`) e siga as instruções de instalação específicas para a tecnologia escolhida (Razor/Blazor ou Next.JS).
5. Configure as opções de autenticação de acordo com as necessidades do projeto.
6. Inicie o aplicativo e comece a utilizar o sistema de gerenciamento de fichas médicas.

## Contribuição

Se você deseja contribuir com este projeto, fique à vontade para abrir uma nova issue ou enviar um pull request. Sua contribuição é valiosa para tornar o sistema ainda melhor!

## Licença

Este projeto está licenciado sob a [licença MIT](LICENSE), permitindo o uso, cópia e modificação do código conforme as diretrizes da licença.

---

Este README fornece um resumo das principais informações sobre o projeto de Gerenciamento de Fichas Médicas. Certifique-se de manter este documento atualizado conforme o projeto evolui e muda ao longo do tempo.
