import br.com.alura.minhasmusicas.modelo.Podcast;

public class Main {
    public static void main(String[] args) {
        Podcast flow = new Podcast();
        flow.setHost("Igor");
        flow.setTitulo("Entrevista com Sergio");
        flow.setDescricao("Entrevista com um dos maiores Cientistas do brasil");
        System.out.println(flow.toString());
    }
}