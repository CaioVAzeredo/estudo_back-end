Banda slipknot = new Banda("Slipknot");

Album albumDoSlipknot = new Album("Iowa");

Musica musica1 = new Musica(slipknot, "Wait and Bleed");
musica1.Duracao = 213;
musica1.Disponivel = false;

Musica musica2 = new Musica(slipknot, "Before I Forget")
{
    Duracao = 430,
    Disponivel = true,
};

albumDoSlipknot.AdicionarMusica(musica1);
albumDoSlipknot.AdicionarMusica(musica2);
slipknot.AdicnionarAlbum(albumDoSlipknot);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoSlipknot.ExibirMusicaDoAlbum();
slipknot.ExibirDiscografia();
