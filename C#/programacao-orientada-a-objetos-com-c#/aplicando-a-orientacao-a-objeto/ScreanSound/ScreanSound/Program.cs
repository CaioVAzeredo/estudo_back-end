Album albumDoSlipknot = new Album();
albumDoSlipknot.Nome = "Iowa";

Musica musica1 = new Musica();
musica1.Nome = "Wait and Bleed";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.Nome = "Before I Forget";
musica2.Duracao = 430;

albumDoSlipknot.AdicionarMusica(musica1);
albumDoSlipknot.AdicionarMusica(musica2);


albumDoSlipknot.ExibirMusicaDoAlbum();