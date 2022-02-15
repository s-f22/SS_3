describe('componente - Rodape', ()=>{

    beforeEach(()=> {
        cy.visit('http://localhost:3000')
    })

    it('Deve existir uma tag footer no corpo do documento', ()=> {
        cy.get('footer').should('exist')
    })

    it('Deve conter o texto da Escola Senai', ()=> {
        cy.get('footer section div p').should('have.text', 'Escola SENAI de Informática - 2021')
    })
    it('Deve verficar se a tag footer está visível e se possui uma classe chamada rodapePricipal', ()=>{
        cy.get('footer').should('be.visible').and('have.class', 'rodapePrincipal')
    })
})