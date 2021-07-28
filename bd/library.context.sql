USE librarydb;

SET CHARACTER SET 'utf8';

SELECT "CRIANDO TABELA 'books'";
CREATE TABLE IF NOT EXISTS books (
	id				CHAR(36)		PRIMARY KEY,
    name 			VARCHAR(60) 	NOT NULL,
    description		VARCHAR(2500)	NOT NULL,
    price			float			NOT NULL,
    author			VARCHAR(30)		NOT NULL,
    sequence		int             NOT NULL
);

SELECT "INSERINDO DADOS NA TABELA";
INSERT INTO 
	books (id,name,description,price,author,sequence) 
VALUES 
	('5ef7cd67-e661-401f-9cd7-5ba3484660d2','Harry Potter e a Pedra Filosofal','Harry Potter e a Pedra Filosofal é o primeiro dos sete livros da série de fantasia Harry Potter, escrita por J. K. Rowling. O livro conta a história de Harry Potter, um órfão criado pelos tios que descobre, em seu décimo primeiro aniversário, que é um bruxo.',25.90,'J. K. Rowling',1),
    ('09cb76ab-5a6c-4765-8a43-aa6478763ac1','Harry Potter e a Câmara Secreta','Harry Potter e a Câmara Secreta é o segundo livro da série Harry Potter. O livro se envolve em torno da lenda de uma câmara secreta localizada na Escola de Magia e Bruxaria de Hogwarts, na qual abriga um monstro que matará a todos os bruxos que não provém de famílias mágicas. Diversos alunos aparecem petrificados e Harry Potter, além de ser apontado como o maior suspeito, tenta desvendar e resolver o mistério junto de seus melhores amigos, Rony Weasley e Hermione Granger.',68.89,'J. K. Rowling',2),
    ('7d2cbb67-1c73-48ac-96a7-9093468a2cae','Harry Potter e o Prisioneiro de Askaban','Harry Potter e o Prisioneiro de Askaban é o terceiro livro da série. As aulas estão de volta a Hogwarts e Harry Potter não vê a hora de embarcar no Expresso a vapor que o levará de volta à escola de bruxaria. Mais uma vez suas férias na rua dos Alfeneiros, 4, foi triste e solitária. Tio Válter Dursley estava especialmente irritado com ele, porque seu amigo Rony Weasley tinha lhe telefonado. E ele não aceitava qualquer ligação de Harry com o mundo dos mágicos dentro de sua casa. A situação piorou ainda mais com a chegada de tia Guida, irmã de Válter. Harry já estava acostumado a ser humilhado pelos Dursley, mas quando tia Guida passou a ofender os pais de Harry, mortos pelo bruxo Voldemort, ele não agüentou e transformou-a num imenso balão. Irritado, fugiu da casa dos tios, indo se abrigar no Beco Diagonal. Lá ele reencontra Rony e Hermione, seus melhores amigos em Hogwarts e, para sua surpresa, é procurado pelo próprio Ministro da Magia. Sem que Harry saiba, o ministro está preocupado com o garoto, pois fugiu da prisão de Azkaban o perigoso bruxo Sirius Black, que teria assassinado treze pessoas com um único feitiço e traído os pais de Harry, entregando-os a Voldemort. Sob forte escolta, o garoto é levado para Hogwarts. Na escola as dificuldades são as de sempre: Severo Snape, o professor de Poções, o trata cada vez pior, enquanto ele tem de se esforçar nos treinos de quadribol, e levar Grifinória à vitória do campeonato. Para piorar a situação, os terríveis guardas de Azkaban, conhecidos por dementadores, estão de guarda nos portões da escola, caso Sirius Black tente algo contra Harry. Por fim, Harry tem de enfrentar seu inimigo para salvar Rony e obrigado a escolher entre matar ou não aquele que traiu seus pais.Com muita ação, humor e magia, Harry Potter e o prisioneiro de Azkaban traz de volta o gigante atrapalhado Rúbeo Hagrid, o sábio diretor Alvo Dumbledore, a exigente professora de transformação Minerva MacGonagall e o novo mestre Lupin, que guarda grandes surpresas para Harry.',68.89,'J. K. Rowling',3),
    ('6b91483f-2671-458d-8e9d-0cd3f4ee3f56','Harry Potter e o Cálice de Fogo','Harry Potter e o Cálice de Fogo é o quarto livro dos sete volumes da série de fantasia Harry Potter, tanto em termos cronológicos como em ordem de publicação, da autora inglesa J. K. Rowling. Foi primeiramente publicado no Reino Unido e nos Estados Unidos em 2000.',50.90,'J. K. Rowling',4),
    ('bde36818-0480-40fd-8d32-d782fef18631','Harry Potter e a Ordem da Fênix','Harry Potter and the Order of the Phoenix é o quinto livro dos sete volumes da série de fantasia Harry Potter, tanto em termos cronológicos como em ordem de publicação, da autora inglesa J. K. Rowling.',60.00,'J. K. Rowling',5),
    ('5cae1b9d-b4f5-4779-90c7-772dd911c49b','Harry Potter e o Enigma do Príncipe','Harry Potter and the Half-Blood Prince é um romance de fantasia escrito pela britânica J. K. Rowling, sendo o sexto dos sete volumes da série Harry Potter.',45.99,'J. K. Rowling',6),
    ('acff35cc-079a-4482-8d62-e30bbe305cde','Harry Potter e as Relíquias da Morte','Harry Potter and the Deathly Hallows é um romance de fantasia escrito pela britânica J. K. Rowling. É o sétimo e último livro da série Harry Potter.',95.50,'J. K. Rowling',7);

SELECT * from books
order by sequence;