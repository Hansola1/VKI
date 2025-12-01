import AppDataSource from '../db/AppDataSource';
import { Group } from '../db/Entity/Group.entity';
import type GroupInterface from '../types/GroupInterface';

export class GroupService {
  private get repository(): ReturnType<typeof AppDataSource.getRepository> {
    return AppDataSource.getRepository(Group);
  }

  async getGroups(): Promise<GroupInterface[]> {
    const groups = await this.repository.find({ relations: ['students'] });
    return groups as GroupInterface[];
  }

  async getGroupsById(id: number): Promise<GroupInterface> {
    const groups = await this.repository.findOne({ relations: ['students'], where: { id } });
    return groups as GroupInterface;
  }

  async addGroup(groupFields: Omit<GroupInterface, 'id'>): Promise<GroupInterface> {
    const group = new Group();
    const newGroup = await this.repository.save({
      ...group,
      ...groupFields,
    });

    return newGroup;
  }
}

export const groupService = new GroupService();