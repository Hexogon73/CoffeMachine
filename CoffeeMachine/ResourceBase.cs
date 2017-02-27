using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeMachine
{
    class ResourceBase
    {
        private Dictionary<string, int> resources_dict = BuildResourcesDict();

        private static Dictionary<string, int> BuildResourcesDict()
        {
            return new Dictionary<string, int>
            {
                {"стакан", 50},{"кофе", 2000},{"вода", 10000},{"сахар", 3000},{"ложка", 50}
            };
        }

        public void ShowAllResource() {
            Console.WriteLine("Запасы ресурсов:");
            foreach (var v in resources_dict)
            {
                    Console.WriteLine("{0} = {1}", v.Key, v.Value);
            }
            Console.WriteLine("==============");
        }

        public int GetResource(string resource_name) {
            int resource_number = -1;
            if (resources_dict.ContainsKey(resource_name))
            {
                foreach (var v in resources_dict)
                {
                    if (v.Key == resource_name)
                    {
                        Console.WriteLine("Запас ресурса '{0}' = {1}", v.Key, v.Value);
                        resource_number = v.Value;
                        return resource_number;
                    }
                }
            }
            else
            {
                Console.WriteLine("ресус '{0}' не обнаружен", resource_name);
                resource_number = -1;
                return resource_number;
            }
            return resource_number;
        }

        public void GetPortion(string resource_name, int portion)
        {
            int resource_number = -1;
            if (resources_dict.ContainsKey(resource_name))
            {
                foreach (var v in resources_dict)
                {
                    if (v.Key == resource_name && v.Value > 0)
                    {
                        resource_number = v.Value;
                        resource_number -= portion;
                        Console.WriteLine("Взято '{0}': {1} осталось: {2}", resource_name, portion, resource_number);
                        resources_dict[resource_name] = resource_number;
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("ресус '{0}' не обнаружен", resource_name);
            }
        }

        public void SetResource(string resource_name, int number)
        {
            if (resources_dict.ContainsKey(resource_name) && number>=0)
            {
                foreach (var v in resources_dict)
                {
                    if (v.Key == resource_name)
                    {
                        resources_dict[resource_name] = number;
                        Console.WriteLine("Установлено значение ресуса '{0}' = {1} прежнее значение", resource_name, number);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("ресус '{0}' не обнаружен", resource_name);
            }
        }
    }
}
