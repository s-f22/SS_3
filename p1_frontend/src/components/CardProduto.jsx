import '../assets/css/style_geral.css'
import produtoImg from '../assets/img/produto1.jpg';

function CardProduto() {
    return (
        <div className='CardProduto_'>
            <img src={produtoImg} alt="" />
            <div className='CardProduto_InfosBasicas'>
                <p>Nome do produto</p>
                <div >
                    <p>R$0,00</p>
                    <button>Comprar</button>
                </div>
            </div>
        </div>
    );
}

export default CardProduto;