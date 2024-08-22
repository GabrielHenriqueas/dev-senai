
import React, { useState } from 'react';
import styled from 'styled-components';

const Container = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
  background-color: #8a2be2;
`;

const TaskCard = styled.div`
  background-color: #1c1c2e;
  padding: 20px;
  border-radius: 10px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
  color: white;
  width: 964px;
  height: 590px;
  text-align: center;
`;

const Title = styled.h2`
  margin-bottom: 20px;
`;

const TaskItem = styled.div`
  background-color: #2b2b44;
  padding: 10px;
  margin: 10px 0;
  border-radius: 5px;
  display: flex;
  justify-content: space-between;
  align-items: center;
`;

const Button = styled.button`
  background-color: #8a2be2;
  border: none;
  padding: 5px;
  margin-left: 5px;
  border-radius: 5px;
  color: white;
  cursor: pointer;

  &:hover {
    background-color: #7a1fe2;
  }
`;

const Input = styled.input`
  background-color: #2b2b44;
  border: none;
  padding: 10px;
  color: white;
  border-radius: 5px;
  width: 100%;
  margin-bottom: 10px;
`;

const ModalOverlay = styled.div`
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.7);
  display: flex;
  justify-content: center;
  align-items: center;
`;

const ModalContent = styled.div`
  background-color: #1c1c2e;
  padding: 20px;
  border-radius: 10px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
  width: 915px;
  height: 472px;
  color: white;
`;

const ModalTitle = styled.h3`
  margin-bottom: 20px;
`;

const ModalButton = styled(Button)`
  margin-top: 20px;
  width: 100%;
`;

const App = () => {
  const [tasks, setTasks] = useState([
    { id: 1, text: 'Começar a execução do projeto', completed: false },
    { id: 2, text: 'Revisar código', completed: false },
  ]);

  const [newTask, setNewTask] = useState('');
  const [searchTerm, setSearchTerm] = useState('');
  const [filteredTasks, setFilteredTasks] = useState(tasks);
  const [isModalOpen, setIsModalOpen] = useState(false);

  const openModal = () => {
    setIsModalOpen(true);
  };

  const closeModal = () => {
    setIsModalOpen(false);
  };

  const addTask = () => {
    if (newTask.trim()) {
      const updatedTasks = [
        ...tasks,
        { id: Date.now(), text: newTask, completed: false },
      ];
      setTasks(updatedTasks);
      setFilteredTasks(updatedTasks);
      setNewTask('');
      closeModal();
    }
  };

  const deleteTask = (id) => {
    const updatedTasks = tasks.filter((task) => task.id !== id);
    setTasks(updatedTasks);
    setFilteredTasks(updatedTasks);
  };

  const toggleComplete = (id) => {
    const updatedTasks = tasks.map((task) =>
      task.id === id ? { ...task, completed: !task.completed } : task
    );
    setTasks(updatedTasks);
    setFilteredTasks(updatedTasks);
  };

  const handleSearch = (e) => {
    const value = e.target.value;
    setSearchTerm(value);
    setFilteredTasks(
      tasks.filter((task) =>
        task.text.toLowerCase().includes(value.toLowerCase())
      )
    );
  };

  // Obter a data atual formatada
  const getCurrentDate = () => {
    const options = { weekday: 'long', day: 'numeric', month: 'long' };
    return new Date().toLocaleDateString('pt-BR', options);
  };

  return (
    <Container>
      <TaskCard>
        <Title>{getCurrentDate()}</Title>
        <Input
          type="text"
          value={searchTerm}
          onChange={handleSearch}
          placeholder="Procurar tarefas"
        />
        <Button onClick={openModal}>Nova tarefa</Button>
        {filteredTasks.map((task) => (
          <TaskItem key={task.id}>
            <input
              type="checkbox"
              checked={task.completed}
              onChange={() => toggleComplete(task.id)}
            />
            <span
              style={{ textDecoration: task.completed ? 'line-through' : 'none' }}
            >
              {task.text}
            </span>
            <Button onClick={() => deleteTask(task.id)}>Delete</Button>
          </TaskItem>
        ))}
      </TaskCard>

      {isModalOpen && (
        <ModalOverlay>
          <ModalContent>
            <ModalTitle>Descreva sua tarefa</ModalTitle>
            <Input
              type="text"
              value={newTask}
              onChange={(e) => setNewTask(e.target.value)}
              placeholder="Exemplo de descrição"
            />
            <ModalButton onClick={addTask}>Confirmar tarefa</ModalButton>
          </ModalContent>
        </ModalOverlay>
      )}
    </Container>
  );
};

export default App;
