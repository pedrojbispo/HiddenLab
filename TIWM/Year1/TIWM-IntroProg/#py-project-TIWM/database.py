turma = {"ID_Turma": "Letra_Turma"}
# aluno = ["ID_Aluno", "Nome", "Nasc", "Nacionalidade"]
aluno = {"ID_Aluno": ["Nome", "Nasc", "Nacionalidade"]}
disciplina = {"ID_Disciplina": "Nome_disciplina"}
#pauta = {"ID": [["ID_Turma"], [["ID_Aluno", "Nome"]], [["ID_Disciplina", "nome_da_disciplna"]], ["M1", "M2", "NotaFinal", "isAproved"]]}
#pauta = {"ID": [["turma"], {"ID_Aluno": ["Nome"]}, {"ID_Disciplina": ["nome_da_disciplna"]}, ["M1", "M2", "NotaFinal", "isAproved"]]}

nested_pauta = { 'turma': {"ID_Turma": "Letra_Turma"},
                'aluno': {"ID_Aluno": ["Nome"]},
                'disciplina': {"ID_Disciplina": ["Nome_disciplina", "M1", "M2", "NotaFinal", "isAproved"]}}




