using Microsoft.Maui.Controls;

namespace MauiAppHotel.Views;

public partial class Avaliacao : ContentPage
{
    public Avaliacao()
    {
        InitializeComponent();
    }

    private void OnSaveMessageClicked(object sender, EventArgs e)
    {
        // Pega o texto da caixa de entrada
        string message = messageEntry.Text;

        // Se houver uma mensagem, exibe-a na Label
        if (!string.IsNullOrWhiteSpace(message))
        {
            savedMessageLabel.Text = message;
            messageEntry.Text = string.Empty; // Limpa a caixa de texto
        }
        else
        {
            savedMessageLabel.Text = "Por favor, insira uma mensagem."; // Mensagem de erro
        }
    }
}
