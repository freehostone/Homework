using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;





// Базовый класс
class Entity
{
    public:
    virtual void displayEntityInfo()
    {
        std::cout << "Это базовая сущность" << std::endl;
    }
};


class Enemy : public Entity
{
public:
    void displayEntityInfo() override
{
    std::cout << "Это враг" << std::endl;
}
};

// Класс для NPC
class NPC : public Entity
{
public:
    void displayEntityInfo() override
{
    std::cout << "Это NPC" << std::endl;
}
};

int main()
{
    std::vector<Entity*> entities;

    // Создание объектов врага и NPC
    Enemy* enemy = new Enemy();
    NPC* npc = new NPC();

    entities.push_back(enemy);
    entities.push_back(npc);

    // Вызов виртуального метода для каждой сущности в массиве
    for (Entity* entity : entities) {
        entity->displayEntityInfo();
    }

    

}


