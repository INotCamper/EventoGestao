using EventoGestao.Data;
using EventoGestao.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoGestao
{
    public partial class Organizar : Form
    {
        private string filePessoa = "pessoas.json";
        private string fileEvento = "evento.json";
        private string fileCafe = "cafe.json";
        private List<Pessoa> pessoas = new List<Pessoa>();
        private List<Evento> eventos = new List<Evento>();
        private List<Cafe> cafes = new List<Cafe>();
        private DataSerializer dt = new DataSerializer();
        public Organizar()
        {
            InitializeComponent();
            lvStatus.View = View.Details;
            lvStatus.Columns.Add("Status").Width = lvStatus.Width;
        }

        private void btnCloseOrganizar_Click(object sender, EventArgs e)
        {
            //Fecha o form
            this.Close();
        }

        private void btnOrganizar_Click(object sender, EventArgs e)
        {
            //pega todas pessoas evento e cafes
            pessoas = dt.JsonDeserializePessoas(filePessoa);
            eventos = dt.JsonDeserializeEvento(fileEvento);
            cafes = dt.JsonDeserializeCafe(fileCafe);

            if (pessoas == null || pessoas.Count <= 0)
            {
                CreateAndAddNewErrorListItem("Não foi possível achar a lista de pessoas, ou nenhuma pessoa foi adicionada");
                return;
            }
            else if (eventos == null || eventos.Count <= 0)
            {
                CreateAndAddNewErrorListItem("Não foi possível achar a lista de sala de eventos, ou nenhuma sala de evento foi adicionada");
                return;
            }
            else if (cafes == null || cafes.Count <= 0)
            {
                CreateAndAddNewErrorListItem("Não foi possível achar a lista de espaços de cafés, ou nenhum espaço de café foi adicionado");
                return;
            }

            //quantidade de pessoas por sala de evento
            int pessoasPorSala = pessoas.Count / eventos.Count;
            int pessoasSobrandoNaDivisaoPorSala = pessoas.Count % eventos.Count;
            //quantidade de pessoas por espaco de cafe
            int pessoasPorEspaco = pessoas.Count / cafes.Count;
            int pessoasSobrandoNaDivisaoPorEspaco = pessoas.Count % cafes.Count;

            //verificar se salas tem capacidade para todas pessoas
            for (int i = 0; i < eventos.Count; i++)
            {
                if (eventos[i].lotacao < pessoasPorSala)
                {
                    CreateAndAddNewErrorListItem("Salas de evento não tem capacidade para todos alunos.");
                    CreateAndAddNewErrorListItem("caso continue a diferença de pessoas entre salas será maior do que um!");
                    return;
                }
            }
            //verificar se salas tem capacidade para todas pessoas
            for (int i = 0; i < cafes.Count; i++)
            {
                if (cafes[i].lotacao < pessoasPorEspaco)
                {
                    CreateAndAddNewErrorListItem("Espaços de café não tem capacidade para todos alunos.");
                    CreateAndAddNewErrorListItem("caso continue a diferença de pessoas entre salas será maior do que um!");
                    return;
                }
            }
            //dividir as pessoas
            //colocar elas nas salas de evento e aplicar a sala de evento nelas
            List<Pessoa> pe = new List<Pessoa>();
            List<string> nomeCompleto = new List<string>();

            //cria o primeiro evento e já preenche as variaveis

            DayOneOrganizer(pessoas, eventos, pessoasPorSala, pessoasSobrandoNaDivisaoPorSala, pe, nomeCompleto);

            // indica que o primeiro evento foi criado
            CreateAndAddNewNominalListItem("------------------------");
            CreateAndAddNewNominalListItem("Primeiro evento criado!");
            pbStatus.Value = 14;

            //cria o primeiro cafe e preenche as variaveis com respectivos espaços de cafe e pessoas, conforme necessario

            DayOneOrganizer(pessoas, cafes, pessoasPorEspaco, pessoasSobrandoNaDivisaoPorEspaco, pe, nomeCompleto);

            //indica que o primeiro cafe foi criado
            CreateAndAddNewNominalListItem("------------------------");
            CreateAndAddNewNominalListItem("Primeiro café criado!");
            pbStatus.Value = 28;

            //cria o segundo evento e ja 

            DayTwoOrganizer(pessoas, eventos, pessoasPorSala, pessoasSobrandoNaDivisaoPorSala, pe, nomeCompleto);

            // indica que o primeiro evento foi criado
            CreateAndAddNewNominalListItem("------------------------");
            CreateAndAddNewNominalListItem("Segundo evento criado!");
            pbStatus.Value = 42;

            //cria e organiza cafe

            DayTwoOrganizer(pessoas, cafes, pessoasPorEspaco, pessoasSobrandoNaDivisaoPorEspaco, pe, nomeCompleto);

            //indica que o primeiro cafe foi criado
            CreateAndAddNewNominalListItem("------------------------");
            CreateAndAddNewNominalListItem("Segundo café criado!");
            pbStatus.Value = 57;

            //indica que todo treinamento foi criado
            CreateAndAddNewNominalListItem("------------------------");
            CreateAndAddNewNominalListItem("TODO TREINAMENTO CRIADO!");

            //salvar todas pessoas
            dt.JsonSerialize(pessoas, filePessoa);
            CreateAndAddNewNominalListItem("------------------------");
            CreateAndAddNewNominalListItem("Pessoas salvas!");
            pbStatus.Value = 71;

            //salvar todos eventos
            dt.JsonSerialize(eventos, fileEvento);
            CreateAndAddNewNominalListItem("------------------------");
            CreateAndAddNewNominalListItem("Salas de Eventos salvas!");
            pbStatus.Value = 85;

            //salvar todos cafes
            dt.JsonSerialize(cafes, fileCafe);
            CreateAndAddNewNominalListItem("------------------------");
            CreateAndAddNewNominalListItem("Espaços de café salvos!");
            pbStatus.Value = 100;
        }

        #region Primeiro Dia
        private void DayOneOrganizer(List<Pessoa> pessoas, List<Cafe> areas, int pessoasPorArea, int pessoasSobraDivisaoArea, List<Pessoa> pessoasEmSala, List<string> nomeCompleto)
        {
            //loop em cada divisao de pessoas
            for (int i = 0; i < pessoas.Count; i += pessoasPorArea)
            {
                //adiciona a pessoa que estiver sobrando
                //caso tenha mais do que uma pessoa sobrando ela sera adicionada no proximo grupo ja que é um if
                if (pessoasSobraDivisaoArea > 0)
                {
                    //adiciona a pessoa na lista da sala
                    pessoasEmSala.Add(pessoas[pessoas.Count - pessoasSobraDivisaoArea]);
                    //aplica a sala na pessoa
                    pessoas[pessoas.Count - pessoasSobraDivisaoArea].cafe1 = areas[i > 0 ? i / pessoasPorArea : i].nome;
                    //diminui a quantidade de pessoas sobrando
                    pessoasSobraDivisaoArea--;
                }
                //loop nas pessoas que estão dentro da divisao sem resto
                for (int j = 0; j < pessoasPorArea; j++)
                {
                    //caso o numero de pessoas vai passar do maximo da lista para esse loop
                    if (i + pessoasPorArea > pessoas.Count)
                        break;
                    //adiciona a respectiva pessoa na lista da sala
                    pessoasEmSala.Add(pessoas[i + j]);
                    //aplica a sala na pessoa
                    pessoas[i + j].cafe1 = areas[i > 0 ? i / pessoasPorArea : i].nome;
                }
                //caso o loop tenha passado do limite para ele
                if (i + pessoasPorArea > pessoas.Count)
                    break;
                //transforma a lista de pessoas em uma lista de string
                foreach (var item in pessoasEmSala)
                {
                    nomeCompleto.Add(item.nome + " " + item.sobrenome);
                }
                //aplica as pessoas na sala
                areas[i > 0 ? i / pessoasPorArea : i].pessoas1 = nomeCompleto.ToArray();
                //limpa a lista de nomes(string)
                nomeCompleto.Clear();
                //limpa a lista de pessoas(Pessoa)
                pessoasEmSala.Clear();
            }
        }
        private void DayOneOrganizer(List<Pessoa> pessoas, List<Evento> areas, int pessoasPorArea, int pessoasSobraDivisaoArea, List<Pessoa> pessoasEmSala, List<string> nomeCompleto)
        {
            //loop em cada divisao de pessoas
            for (int i = 0; i < pessoas.Count; i += pessoasPorArea)
            {
                //adiciona a pessoa que estiver sobrando
                //caso tenha mais do que uma pessoa sobrando ela sera adicionada no proximo grupo ja que é um if
                if (pessoasSobraDivisaoArea > 0)
                {
                    //adiciona a pessoa na lista da sala
                    pessoasEmSala.Add(pessoas[pessoas.Count - pessoasSobraDivisaoArea]);
                    //aplica a sala na pessoa
                    pessoas[pessoas.Count - pessoasSobraDivisaoArea].evento1 = areas[i > 0 ? i / pessoasPorArea : i].nome;
                    //diminui a quantidade de pessoas sobrando
                    pessoasSobraDivisaoArea--;
                }
                //loop nas pessoas que estão dentro da divisao sem resto
                for (int j = 0; j < pessoasPorArea; j++)
                {
                    //caso o numero de pessoas vai passar do maximo da lista para esse loop
                    if (i + pessoasPorArea > pessoas.Count)
                        break;
                    //adiciona a respectiva pessoa na lista da sala
                    pessoasEmSala.Add(pessoas[i + j]);
                    //aplica a sala na pessoa
                    pessoas[i + j].evento1 = areas[i > 0 ? i / pessoasPorArea : i].nome;
                }
                //caso o loop tenha passado do limite para ele
                if (i + pessoasPorArea > pessoas.Count)
                    break;
                //transforma a lista de pessoas em uma lista de string
                foreach (var item in pessoasEmSala)
                {
                    nomeCompleto.Add(item.nome + " " + item.sobrenome);
                }
                //aplica as pessoas na sala
                areas[i > 0 ? i / pessoasPorArea : i].pessoas1 = nomeCompleto.ToArray();
                //limpa a lista de nomes(string)
                nomeCompleto.Clear();
                //limpa a lista de pessoas(Pessoa)
                pessoasEmSala.Clear();
            }
        }
        #endregion

        #region Segundo Dia
        private void DayTwoOrganizer(List<Pessoa> pessoas, List<Cafe> areas, int pessoasPorArea, int pessoasSobraDivisaoArea, List<Pessoa> pessoasEmSala, List<string> nomeCompleto)
        {
            //listas para dividir cada sala na metade e passar metade da sala para outra
            List<Pessoa> salaAtual = new List<Pessoa>();
            List<Pessoa> proximaSala = new List<Pessoa>();
            //criar uma sala com metade da sla do primeiro dia + metade da sala anterior
            List<Pessoa> sala = new List<Pessoa>();
            //como a sala 0 nao tem anterior tenho que salvar ela ate o fim, quando terei a metade da ultima sala
            List<Pessoa> sala0 = new List<Pessoa>();
            //loop em cada divisao de pessoas
            for (int i = 0; i < pessoas.Count; i += pessoasPorArea)
            {
                //adiciona a pessoa que estiver sobrando
                //caso tenha mais do que uma pessoa sobrando ela sera adicionada no proximo grupo ja que é um if
                if (pessoasSobraDivisaoArea > 0)
                {
                    //adiciona a pessoa na lista da sala
                    pessoasEmSala.Add(pessoas[pessoas.Count - pessoasSobraDivisaoArea]);
                    //diminui a quantidade de pessoas sobrando
                    pessoasSobraDivisaoArea--;
                }
                //loop nas pessoas que estão dentro da divisao sem resto
                for (int j = 0; j < pessoasPorArea; j++)
                {
                    //caso o numero de pessoas vai passar do maximo da lista para esse loop
                    if (i + pessoasPorArea > pessoas.Count)
                        break;
                    //adiciona a respectiva pessoa na lista da sala
                    pessoasEmSala.Add(pessoas[i + j]);
                }
                //caso o loop tenha passado do limite para ele
                if (i + pessoasPorArea > pessoas.Count)
                    break;
                //a cada pessoaPorArea adicionada no i, estamos em outra sala, logo se i for 0, estamos na primeira sala
                if (i <= 0)
                {
                    //pega duas pessoas da sala 0
                    var pes = pessoasEmSala.Take(pessoasEmSala.Count / 2);
                    foreach (var item in pes)
                    {
                        salaAtual.Add(item);
                    }
                    //adiciona na sala atual
                    //pega as outras pessoas da sala e manda para sala0
                    var sal = pessoasEmSala.Skip(pessoasEmSala.Count / 2).Take(pessoasEmSala.Count - (pessoasEmSala.Count / 2));
                    foreach (var item in sal)
                    {
                        sala0.Add(item);
                    }
                    //limpa as pessoas em sala do primeiro dia
                    pessoasEmSala.Clear();
                }
                //caso o i for diferente de 0, estamos em outras salas (para ser mais especifico, a cada vez q virmos i/pessoasPorArea estamos indo para alguma sala, dependendo do valor de i
                else
                {
                    // metade da sala
                    var pes = pessoasEmSala.Take(pessoasEmSala.Count / 2);
                    //passa para a variavel que vai mandar para a proxima sala
                    foreach (var item in pes)
                    {
                        proximaSala.Add(item);
                    }
                    //adiciona as outras pessoas na sala
                    var sal = pessoasEmSala.Skip(pessoasEmSala.Count / 2).Take(pessoasEmSala.Count - (pessoasEmSala.Count / 2));
                    foreach (var item in sal)
                    {
                        sala.Add(item);
                    }
                    //limpa a sala da dia 1
                    pessoasEmSala.Clear();
                    //adiciona as pessoas da sla anterior
                    foreach (var item in salaAtual)
                    {
                        sala.Add(item);
                    }
                    //limpa a sala anterior
                    salaAtual.Clear();
                    //passa as pessoas que foram tiradas dessa sala para a variavel que vai mandar para a proxima sala
                    foreach (var item in proximaSala)
                    {
                        salaAtual.Add(item);
                    }
                    //limpa as pessoas que foram passadas da sala atual para poder ser preenchido com as pessoas da proxima sala
                    proximaSala.Clear();
                }
                //hora de salvar
                //caso estivermos em i diferente de 0 (ou seja, estamos em alguma sala alem da sala[0]
                if (i != 0)
                {
                    //cria a lista de nomes de pessoas que estao na sala indicada por i/pessoasPorArea
                    foreach (var item in sala)
                    {
                        nomeCompleto.Add(item.nome + " " + item.sobrenome);
                        //como dessa vez eu perco a referencia de cada pessoa devido ao fato de metade da sala ser mudada apos ser feita, tenho que buscar a referencia de cada pessoa na lista de pessoas
                        foreach (var pessoa in pessoas)
                        {
                            //procuro cada pessoa com nome e sobrenome igual, logo é a mesma pessoa (já que na hora de cadastrar cada pessoa, eu faço a mesma ação para não ter duplicatas de pessoas)
                            if (pessoa.nome == item.nome && pessoa.sobrenome == item.sobrenome)
                            {
                                //coloco a pessoa na sala
                                pessoa.cafe2 = areas[i / pessoasPorArea].nome;
                            }
                        }
                    }
                    //aplica as pessoas na sala
                    areas[i / pessoasPorArea].pessoas2 = nomeCompleto.ToArray();
                    //limpo a sala, para ser preenchida com as pessoas da proxima sala e metade dessa sala
                    sala.Clear();
                    //limpo a lista de nomes
                    nomeCompleto.Clear();
                }
            }
            //quando o loop acima acabar, teremos metade da sala 0, e metade da ultima sala
            //adiciona metade da ultima sala na sala0
            foreach (var item in salaAtual)
            {
                sala0.Add(item);
            }
            //limpa a variavel que nos ajudou a guardar cada metade de sala
            salaAtual.Clear();
            //aplica todos da sala0 na sala[0]
            foreach (var item in sala0)
            {
                //mesmo acontecimento das outras salas, mas ao inves de o numero da sala depender de i/pessoasPorArea agora estamos indo direto para a sala[o]
                nomeCompleto.Add(item.nome + " " + item.sobrenome);
                foreach (var pessoa in pessoas)
                {
                    if (pessoa.nome == item.nome && pessoa.sobrenome == item.sobrenome)
                    {
                        pessoa.cafe2 = areas[0].nome;
                    }
                }
            }
            //aplica as pessoas na sala
            areas[0].pessoas2 = nomeCompleto.ToArray();
            //limpa a sala0
            sala0.Clear();
            //limpa a lista de nomes
            nomeCompleto.Clear();
        }
        private void DayTwoOrganizer(List<Pessoa> pessoas, List<Evento> areas, int pessoasPorArea, int pessoasSobraDivisaoArea, List<Pessoa> pessoasEmSala, List<string> nomeCompleto)
        {
            //listas para dividir cada sala na metade e passar metade da sala para outra
            List<Pessoa> salaAtual = new List<Pessoa>();
            List<Pessoa> proximaSala = new List<Pessoa>();
            //criar uma sala com metade da sla do primeiro dia + metade da sala anterior
            List<Pessoa> sala = new List<Pessoa>();
            //como a sala 0 nao tem anterior tenho que salvar ela ate o fim, quando terei a metade da ultima sala
            List<Pessoa> sala0 = new List<Pessoa>();
            //loop em cada divisao de pessoas
            for (int i = 0; i < pessoas.Count; i += pessoasPorArea)
            {
                //adiciona a pessoa que estiver sobrando
                //caso tenha mais do que uma pessoa sobrando ela sera adicionada no proximo grupo ja que é um if
                if (pessoasSobraDivisaoArea > 0)
                {
                    //adiciona a pessoa na lista da sala
                    pessoasEmSala.Add(pessoas[pessoas.Count - pessoasSobraDivisaoArea]);
                    //diminui a quantidade de pessoas sobrando
                    pessoasSobraDivisaoArea--;
                }
                //loop nas pessoas que estão dentro da divisao sem resto
                for (int j = 0; j < pessoasPorArea; j++)
                {
                    //caso o numero de pessoas vai passar do maximo da lista para esse loop
                    if (i + pessoasPorArea > pessoas.Count)
                        break;
                    //adiciona a respectiva pessoa na lista da sala
                    pessoasEmSala.Add(pessoas[i + j]);
                }
                //caso o loop tenha passado do limite para ele
                if (i + pessoasPorArea > pessoas.Count)
                    break;
                //a cada pessoaPorArea adicionada no i, estamos em outra sala, logo se i for 0, estamos na primeira sala
                if (i <= 0)
                {
                    //pega duas pessoas da sala 0
                    var pes = pessoasEmSala.Take(pessoasEmSala.Count / 2);
                    foreach (var item in pes)
                    {
                        salaAtual.Add(item);
                    }
                    //adiciona na sala atual
                    //pega as outras pessoas da sala e manda para sala0
                    var sal = pessoasEmSala.Skip(pessoasEmSala.Count / 2).Take(pessoasEmSala.Count - (pessoasEmSala.Count / 2));
                    foreach (var item in sal)
                    {
                        sala0.Add(item);
                    }
                    //limpa as pessoas em sala do primeiro dia
                    pessoasEmSala.Clear();
                }
                //caso o i for diferente de 0, estamos em outras salas (para ser mais especifico, a cada vez q virmos i/pessoasPorArea estamos indo para alguma sala, dependendo do valor de i
                else
                {
                    // metade da sala
                    var pes = pessoasEmSala.Take(pessoasEmSala.Count / 2);
                    //passa para a variavel que vai mandar para a proxima sala
                    foreach (var item in pes)
                    {
                        proximaSala.Add(item);
                    }
                    //adiciona as outras pessoas na sala
                    var sal = pessoasEmSala.Skip(pessoasEmSala.Count / 2).Take(pessoasEmSala.Count - (pessoasEmSala.Count / 2));
                    foreach (var item in sal)
                    {
                        sala.Add(item);
                    }
                    //limpa a sala da dia 1
                    pessoasEmSala.Clear();
                    //adiciona as pessoas da sla anterior
                    foreach (var item in salaAtual)
                    {
                        sala.Add(item);
                    }
                    //limpa a sala anterior
                    salaAtual.Clear();
                    //passa as pessoas que foram tiradas dessa sala para a variavel que vai mandar para a proxima sala
                    foreach (var item in proximaSala)
                    {
                        salaAtual.Add(item);
                    }
                    //limpa as pessoas que foram passadas da sala atual para poder ser preenchido com as pessoas da proxima sala
                    proximaSala.Clear();
                }
                //hora de salvar
                //caso estivermos em i diferente de 0 (ou seja, estamos em alguma sala alem da sala[0]
                if (i != 0)
                {
                    //cria a lista de nomes de pessoas que estao na sala indicada por i/pessoasPorArea
                    foreach (var item in sala)
                    {
                        nomeCompleto.Add(item.nome + " " + item.sobrenome);
                        //como dessa vez eu perco a referencia de cada pessoa devido ao fato de metade da sala ser mudada apos ser feita, tenho que buscar a referencia de cada pessoa na lista de pessoas
                        foreach (var pessoa in pessoas)
                        {
                            //procuro cada pessoa com nome e sobrenome igual, logo é a mesma pessoa (já que na hora de cadastrar cada pessoa, eu faço a mesma ação para não ter duplicatas de pessoas)
                            if (pessoa.nome == item.nome && pessoa.sobrenome == item.sobrenome)
                            {
                                //coloco a pessoa na sala
                                pessoa.evento2 = areas[i / pessoasPorArea].nome;
                            }
                        }
                    }
                    //aplica as pessoas na sala
                    areas[i / pessoasPorArea].pessoas2 = nomeCompleto.ToArray();
                    //limpo a sala, para ser preenchida com as pessoas da proxima sala e metade dessa sala
                    sala.Clear();
                    //limpo a lista de nomes
                    nomeCompleto.Clear();
                }
            }
            //quando o loop acima acabar, teremos metade da sala 0, e metade da ultima sala
            //adiciona metade da ultima sala na sala0
            foreach (var item in salaAtual)
            {
                sala0.Add(item);
            }
            //limpa a variavel que nos ajudou a guardar cada metade de sala
            salaAtual.Clear();
            //aplica todos da sala0 na sala[0]
            foreach (var item in sala0)
            {
                //mesmo acontecimento das outras salas, mas ao inves de o numero da sala depender de i/pessoasPorArea agora estamos indo direto para a sala[o]
                nomeCompleto.Add(item.nome + " " + item.sobrenome);
                foreach (var pessoa in pessoas)
                {
                    if (pessoa.nome == item.nome && pessoa.sobrenome == item.sobrenome)
                    {
                        pessoa.evento2 = areas[0].nome;
                    }
                }
            }
            //aplica as pessoas na sala
            areas[0].pessoas2 = nomeCompleto.ToArray();
            //limpa a sala0
            sala0.Clear();
            //limpa a lista de nomes
            nomeCompleto.Clear();
        }
        #endregion

        private void CreateAndAddNewErrorListItem(string texto)
        {
            //cria um listviewitem com base no que foi escrito
            var listViewItem = new ListViewItem(texto);
            //aplica cor nele
            listViewItem.ForeColor = Color.Red;
            //adiciona ele na listview
            lvStatus.Items.Add(listViewItem);
        }

        private void CreateAndAddNewNominalListItem(string texto)
        {
            //cria um listviewitem com base no que foi escrito
            var listViewItem = new ListViewItem(texto);
            //aplica cor nele
            listViewItem.ForeColor = Color.Green;
            //adiciona ele na listview
            lvStatus.Items.Add(listViewItem);
        }
    }
}
