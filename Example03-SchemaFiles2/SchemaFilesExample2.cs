/*
 * Copyright 2020 James Courtney
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using SharpFuzz;
using System.IO;
using System.Text;

namespace Samples.SchemaFilesExample2;

/// <summary>
/// This sample shows the usage of FlatSharp when declaring types and serializers.
/// </summary>
/// <remarks>
/// Based on the monster sample here:
/// https://google.github.io/flatbuffers/flatbuffers_guide_tutorial.html
/// </remarks>
public class SchemaFilesExample2
{
    public static void Run()
    {
        Fuzzer.Run(stream =>
        {
            try
            {
                // These types are generated from SchemaFilesExample.fbs

                //Owner owner1 = new()
                //{
                //    Name = "John",
                //    //Document = File.ReadAllBytes(@"C:\src\fuzzing\Fuzzing\CatStory.txt"),
                //    //CostOfAllCatsInTotal = 105629.0000999888m
                //};

                //Owner owner2 = new()
                //{
                //    Name = "Alice",
                //    //Document = File.ReadAllBytes(@"C:\src\fuzzing\Fuzzing\CatStory.txt"),
                //    //CostOfAllCatsInTotal = 165629.0000929888m
                //};

                //var cats = new Cat[9];

                //for (int i = 0; i < 9; i++)
                //{
                //    Cat c = new()
                //    {
                //        AgeInYears = (uint)i * 2 + 1,
                //        IsFluffy = i % 2 == 0,
                //        Name = "Pet" + i,
                //        Breed = (CatBreed)i,
                //        Whatever = DateTime.UtcNow.Ticks,
                //        GramsOfFoodPerDay = 33.6 * i + 100,
                //        UniqueIdentfier = "Cat_Id_" + i
                //    };
                //    cats[i] = c;
                //}

                //cats[1].Children = new Cat[] { cats[3] };
                //cats[2].Children = new Cat[] { cats[4], cats[8] };

                //owner1.Cats = new List<Cat>();
                //for (int i = 0; i < 5; i++)
                //{
                //    owner1.Cats.Add(cats[i]);
                //}

                //owner2.Cats = new List<Cat>();
                //for (int i = 5; i < 9; i++)
                //{
                //    owner2.Cats.Add(cats[i]);
                //}

                //CatsAndOwnersContainer container = new()
                //{
                //    cats = cats,
                //};

                ////Serializer is pregenerated, so no first - run penalty for FlatBufferSerializer.
                //int maxBytes = CatsAndOwnersContainer.Serializer.GetMaxSize(container);
                //byte[] destination = new byte[maxBytes];
                //int bytesWritten = CatsAndOwnersContainer.Serializer.Write(destination, container);
                //File.WriteAllBytes(@"C:\src\fuzzing\Fuzzing2\TestCases\TestCases.txt", destination);
                //Console.WriteLine(bytesWritten);

                CatsAndOwnersContainer.Serializer.Parse(Encoding.UTF8.GetBytes(stream));
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
            }
        });
    }
}