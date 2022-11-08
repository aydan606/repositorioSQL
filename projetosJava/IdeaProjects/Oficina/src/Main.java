//
// Source code recreated from a .class file by IntelliJ IDEA
// (powered by FernFlower decompiler)
//

import javax.swing.*;
import java.text.DecimalFormat;

class Carro {
    private String marca;
    private String modelo;
    private String placa;
    private String descricao;
    private double valorServico;

    public Carro() {
    }

    public String getMarca() {
        return this.marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getModelo() {
        return this.modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public String getPlaca() {
        return this.placa;
    }

    public void setPlaca(String placa) {
        this.placa = placa;
    }

    public String getDescricao() {
        return this.descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public double getValorServico() {
        return this.valorServico;
    }

    public void setValorServico(double valorServico) {
        this.valorServico = valorServico;
    }
}

class Oficina {
    static int totalVagas = 30;
    int vaga;
    String doubleConv;
    Carro[] carro = new Carro[totalVagas];

    public void entradaCarro() {
        for(int i = 0; i < totalVagas; i++) {
            if (this.carro[i] == null) {
                this.carro[i] = new Carro();
                this.carro[i].setMarca(JOptionPane.showInputDialog("Insira a marca: "));
                this.carro[i].setModelo(JOptionPane.showInputDialog("Insira o modelo: "));

                boolean aux;
                do {
                    this.carro[i].setPlaca(JOptionPane.showInputDialog("Digite a placa:"));
                    if (!this.carro[i].getPlaca().matches("[A-Z]{3}-[0-9]{4}") || this.carro[i].getPlaca().matches("[A-Z]{3}[0-9][A-Z][0-9]{2}")) {
                        JOptionPane.showMessageDialog(null, "Placa inválida, tente novamente!", "Erro", JOptionPane.ERROR_MESSAGE);
                        aux = true;
                    } else {
                        JOptionPane.showMessageDialog(null, "Carro cadastrado na vaga " + i);
                        aux = false;
                    }
                } while(aux);

                return;
            }
        }
    }

    public void lancarServico() {
        if (vaga < 0 || vaga >= totalVagas) {
            JOptionPane.showMessageDialog(null, "Vaga inexistente, por favor tente novamente.", "Erro", JOptionPane.ERROR_MESSAGE);
            lancarServico();
        }

        vaga = Integer.parseInt(JOptionPane.showInputDialog("Digite a vaga do carro em questão: "));
        carro[vaga].setDescricao(JOptionPane.showInputDialog("Descreva o serviço realizado: "));
        carro[vaga].setValorServico(Double.parseDouble(JOptionPane.showInputDialog("Digite o valor do serviço: ")));
        DecimalFormat df = new DecimalFormat("0.00");
        doubleConv = df.format(carro[vaga].getValorServico());
        JOptionPane.showMessageDialog(null, "Serviço lançado!");
    }

    public void liberacaoCarro() {
        vaga = Integer.parseInt(JOptionPane.showInputDialog("Digite a vaga do carro em questão: "));
        if (carro[vaga] == null) {
            JOptionPane.showMessageDialog(null, "Vaga não possui cadastro de carro! Tente novamente.", "Erro", JOptionPane.ERROR_MESSAGE);
            liberacaoCarro();
        }

        if (vaga < 0 || vaga >= totalVagas) {
            JOptionPane.showMessageDialog(null, "Vaga inexistente, por favor tente novamente.", "Erro", JOptionPane.ERROR_MESSAGE);
            lancarServico();
        }

        if (carro[vaga].getDescricao() == null && carro[vaga].getValorServico() == 0.0) {
            JOptionPane.showMessageDialog(null, "Serviço deste carro não foi lançado no sistema!", "Erro", JOptionPane.ERROR_MESSAGE);
            JOptionPane.showMessageDialog(null, "Abrindo tela de lançamento de serviço...");
            lancarServico();
        } else {
            int opcao = JOptionPane.showConfirmDialog(null, "Confirme os dados do carro em questão:\nCarro: " + carro[vaga].getMarca() + " " + carro[vaga].getModelo() + "\nPlaca: " + carro[vaga].getPlaca());
            if (opcao == 0) {
                JOptionPane.showMessageDialog(null, "Descrição do serviço: " + carro[vaga].getDescricao() + "\nValor do serviço: R$ " + doubleConv);
                carro[vaga] = null;
            } else if (opcao == 1) {
                this.liberacaoCarro();
            } else if (opcao == 2) {
                return;
            }

            JOptionPane.showMessageDialog(null, "Vaga liberada!");
        }

    }

    public void listarCarros() {
        StringBuilder aux = new StringBuilder();

        for(int i = 0; i < totalVagas; i++) {
            if (carro[i] != null) {
                aux.append("Vaga ").append(i).append(": ").append(carro[i].getMarca()).append(" ").append(carro[i].getModelo()).append(", placa nº ").append(carro[i].getPlaca()).append("\n");
            }
            else {
                JOptionPane.showMessageDialog(null, "Oficina vazia!");
                return;
            }
        }

        JOptionPane.showMessageDialog(null, aux.toString(), "Lista de Carros", JOptionPane.INFORMATION_MESSAGE);
    }

    public void listarVagas() {
        StringBuilder aux = new StringBuilder();

        for(int i = 0; i < totalVagas; i++) {
            if (carro[i] == null) {
                aux.append("[").append(i).append("] ");
            } else {
                aux.append("[").append(carro[i].getPlaca()).append("] ");
            }
        }

        JOptionPane.showMessageDialog(null, aux.toString(), "Lista de Vagas", JOptionPane.INFORMATION_MESSAGE);
    }
}

public class Main {

    public static void main(String[] args) {
        JOptionPane.showMessageDialog(null, "Seja bem-vindo ao sistema de gerenciamento de veículos!");
        programaPrincipal();
    }

    public static void programaPrincipal() {
        Oficina Oficina = new Oficina();

        int menu;
        try {
            do {
                String aux = JOptionPane.showInputDialog("Insira o valor associado a mensagem:\n0 - Sair do sistema\n1 - Cadastro de veículo\n2 - Lançamento de serviço\n3 - Liberação de veículo\n4 - Listar veículos nas vagas\n5 - Listar todas as vagas");
                if (aux == null) {
                    break;
                }

                menu = Integer.parseInt(aux);
                switch (menu) {
                    case 0 -> JOptionPane.showMessageDialog(null, "Encerrando sistema...");
                    case 1 -> Oficina.entradaCarro();
                    case 2 -> Oficina.lancarServico();
                    case 3 -> Oficina.liberacaoCarro();
                    case 4 -> Oficina.listarCarros();
                    case 5 -> Oficina.listarVagas();
                    default -> JOptionPane.showMessageDialog(null, "Opção inválida, tente novamente.", "Erro", JOptionPane.ERROR_MESSAGE);
                }
            } while(menu != 0);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Insira somente números inteiros!", "Erro", JOptionPane.ERROR_MESSAGE);
            programaPrincipal();
        }

    }
}