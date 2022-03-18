import '../assets/css/style_geral.css'
import { Navbar, NavbarBrand, NavbarToggler, Collapse, Nav, NavItem, NavLink, UncontrolledDropdown, DropdownToggle, DropdownMenu, DropdownItem, NavbarText } from 'reactstrap';

import logo from '../assets/img/account_circle_white_24dp.svg';

function Cabecalho() {
  return (
    <header className='Cabecalho_WidthTotal'>
      <div className="Cabecalho_MaxWidht">
        <a href="">Logo</a>
        <form action="">
          <input placeholder="Busca" type="text" />
          <button type="submit">OK</button>
        </form>

        <Navbar
          // color="light"
          expand="md" light>
          <NavbarToggler onClick={function noRefCheck() { }} />
          <Collapse navbar>
            <Nav className="me-auto" navbar>
              <UncontrolledDropdown inNavbar nav>
                <DropdownToggle caret nav className='corAlternativa'>
                  <img src={logo} alt="" className='userImage' />
                </DropdownToggle>
                <DropdownMenu right>
                  <DropdownItem>
                    Meu cadastro
                  </DropdownItem>
                  <DropdownItem>
                    Meus produtos
                  </DropdownItem>
                </DropdownMenu>
              </UncontrolledDropdown>
            </Nav>
          </Collapse>
        </Navbar>
      </div>
    </header>
  );
}

export default Cabecalho;