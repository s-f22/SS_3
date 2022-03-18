import '../assets/css/style_geral.css'
import CardProduto from "../components/CardProduto";

function QuadroCards() {
    return (
        <section className='QuadroCards_AreaTotal'>
            <div className='QuadroCards_Section'>
                <CardProduto />
                <CardProduto />
                <CardProduto />
                <CardProduto />
                <CardProduto />
                <CardProduto />
                <CardProduto />
            </div>
        </section>
    );
}

export default QuadroCards;