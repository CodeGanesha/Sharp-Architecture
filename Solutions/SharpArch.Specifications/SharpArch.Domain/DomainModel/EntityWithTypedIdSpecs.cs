//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

#pragma warning disable 169
// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace SharpArch.Specifications.SharpArch.Domain.DomainModel
{
    using System.Collections.Generic;
    using System.Reflection;

    using global::SharpArch.Domain.DomainModel;
    using global::SharpArch.Testing.NUnit.Helpers;

    using Machine.Specifications;


    public class entity_with_type_id_specs
    {
        public class specification_for_entity_with_typed_id
        {
            protected class EntityWithNoDomainSignatureProperties : EntityWithTypedId<int>
            {
                public string Property1 { get; set; }

                public int Property2 { get; set; }
            }

            protected class EntityWithAllPropertiesPartOfDomainSignature : EntityWithTypedId<int>
            {
                [DomainSignature]
                public string Property1 { get; set; }

                [DomainSignature]
                public int Property2 { get; set; }

                [DomainSignature]
                public bool Property3 { get; set; }
            }

            protected class EntityWithSomePropertiesPartOfDomainSignature : EntityWithTypedId<int>
            {
                [DomainSignature]
                public string Property1 { get; set; }

                public int Property2 { get; set; }

                [DomainSignature]
                public bool Property3 { get; set; }
            }

            protected class EntityWithAnotherEntityAsPartOfDomainSignature : EntityWithTypedId<int>
            {
                public EntityWithAnotherEntityAsPartOfDomainSignature()
                {
                    this.Property2 = new EntityWithAllPropertiesPartOfDomainSignature();
                }

                [DomainSignature]
                public string Property1 { get; set; }

                [DomainSignature]
                public EntityWithAllPropertiesPartOfDomainSignature Property2 { get; set; }
            }
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class just_testing : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity1;
            static EntityWithAllPropertiesPartOfDomainSignature entity2;

            Establish context = () => entity1 = entity2 = new EntityWithAllPropertiesPartOfDomainSignature();

            private It should_treat_them_as_equal = () => entity1.Equals(entity2).Equals(true);
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_variables_that_reference_the_same_instance_of_an_entity_are_compared : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity1;
            static EntityWithAllPropertiesPartOfDomainSignature entity2;

            Establish context = () => entity1 = entity2 = new EntityWithAllPropertiesPartOfDomainSignature();

            It should_treat_them_as_equal = () => entity1.Equals(entity2).ShouldBeTrue();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_entities_with_all_properties_being_part_of_their_domain_signature_are_compared_and_all_property_values_are_the_same : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity1;
            static EntityWithAllPropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithAllPropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
                entity2 = new EntityWithAllPropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
            };

            It should_treat_them_as_equal = () => entity1.Equals(entity2).ShouldBeTrue();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_entities_with_all_properties_being_part_of_their_domain_signature_are_compared_and_any_property_value_is_different : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity1;
            static EntityWithAllPropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithAllPropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
                entity2 = new EntityWithAllPropertiesPartOfDomainSignature { Property1 = "property 1 different", Property2 = 2, Property3 = true };
            };

            It should_treat_them_as_not_equal = () => entity1.Equals(entity2).ShouldBeFalse();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_entities_with_some_properties_being_part_of_their_domain_signature_are_compared_and_all_property_values_are_the_same : specification_for_entity_with_typed_id
        {
            static EntityWithSomePropertiesPartOfDomainSignature entity1;
            static EntityWithSomePropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithSomePropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
                entity2 = new EntityWithSomePropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
            };

            It should_treat_them_as_equal = () => entity1.Equals(entity2).ShouldBeTrue();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_entities_with_some_properties_being_part_of_their_domain_signature_are_compared_and_the_value_of_a_property_that_is_part_of_the_domain_signature_is_different : specification_for_entity_with_typed_id
        {
            static EntityWithSomePropertiesPartOfDomainSignature entity1;
            static EntityWithSomePropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithSomePropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
                entity2 = new EntityWithSomePropertiesPartOfDomainSignature { Property1 = "property 1 is different", Property2 = 2, Property3 = true };
            };

            It should_treat_them_as_not_equal = () => entity1.Equals(entity2).ShouldBeFalse();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_entities_with_some_properties_being_part_of_their_domain_signature_are_compared_and_the_value_of_a_property_that_is_not_part_of_the_domain_signature_is_different : specification_for_entity_with_typed_id
        {
            static EntityWithSomePropertiesPartOfDomainSignature entity1;
            static EntityWithSomePropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithSomePropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
                entity2 = new EntityWithSomePropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 200, Property3 = true };
            };

            It should_treat_them_as_equal = () => entity1.Equals(entity2).ShouldBeTrue();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_entities_that_have_the_same_id_but_different_values_for_the_properties_that_are_part_of_their_domain_signature_are_compared : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity1;
            static EntityWithAllPropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithAllPropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
                entity2 = new EntityWithAllPropertiesPartOfDomainSignature { Property1 = "property 1 different", Property2 = 200, Property3 = false };
                entity1.SetIdTo(10);
                entity2.SetIdTo(10);
            };

            It should_treat_them_as_equal = () => entity1.Equals(entity2).ShouldBeTrue();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_entities_that_have_different_ids_but_the_same_values_for_the_properties_that_are_part_of_their_domain_signature_are_compared : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity1;
            static EntityWithAllPropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithAllPropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
                entity2 = new EntityWithAllPropertiesPartOfDomainSignature { Property1 = "property 1", Property2 = 2, Property3 = true };
                entity1.SetIdTo(10);
                entity2.SetIdTo(20);
            };

            It should_treat_them_as_not_equal = () => entity1.Equals(entity2).ShouldBeFalse();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_entities_that_have_another_entity_as_a_property_belonging_to_the_domain_signature_are_compared_and_the_properties_have_the_same_value : specification_for_entity_with_typed_id
        {
            static EntityWithAnotherEntityAsPartOfDomainSignature entity1;
            static EntityWithAnotherEntityAsPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithAnotherEntityAsPartOfDomainSignature { Property1 = "property 1" };
                entity1.Property2.SetIdTo(10);
                entity2 = new EntityWithAnotherEntityAsPartOfDomainSignature { Property1 = "property 1" };
                entity2.Property2.SetIdTo(10);
            };

            It should_treat_them_as_equal = () => entity1.Equals(entity2).ShouldBeTrue();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_entities_that_have_another_entity_as_a_property_belonging_to_the_domain_signature_are_compared_and_the_properties_have_different_values : specification_for_entity_with_typed_id
        {
            static EntityWithAnotherEntityAsPartOfDomainSignature entity1;
            static EntityWithAnotherEntityAsPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithAnotherEntityAsPartOfDomainSignature { Property1 = "property 1" };
                entity1.Property2.SetIdTo(10);
                entity2 = new EntityWithAnotherEntityAsPartOfDomainSignature { Property1 = "property 1" };
                entity2.Property2.SetIdTo(20);
            };

            It should_treat_them_as_not_equal = () => entity1.Equals(entity2).ShouldBeFalse();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_an_entity_is_asked_for_the_properties_that_make_up_its_domain_signature : specification_for_entity_with_typed_id
        {
            static IEnumerable<PropertyInfo> result;

            Because of = () => result = new EntityWithAllPropertiesPartOfDomainSignature().GetSignatureProperties();

            It should_return_the_property_information_for_the_signature_properties = () =>
            {
                var entityType = typeof(EntityWithAllPropertiesPartOfDomainSignature);

                IList<PropertyInfo> expectedProperties = new List<PropertyInfo>
                    {
                        entityType.GetProperty("Property1"),
                        entityType.GetProperty("Property2"),
                        entityType.GetProperty("Property3")
                    };

                result.ShouldContainOnly(expectedProperties);
            };
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_an_entity_is_asked_for_the_properties_that_make_up_its_domain_signature_and_there_are_none : specification_for_entity_with_typed_id
        {
            static IEnumerable<PropertyInfo> result;

            Because of = () => result = new EntityWithNoDomainSignatureProperties().GetSignatureProperties();

            It should_return_an_empty_list = () => result.ShouldBeEmpty();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_two_different_entity_subclasses_with_the_same_id_are_compared : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity1;
            static EntityWithSomePropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithAllPropertiesPartOfDomainSignature();
                entity1.SetIdTo(10);
                entity2 = new EntityWithSomePropertiesPartOfDomainSignature();
                entity2.SetIdTo(10);
            };

            It should_treat_them_as_not_equal = () => (entity1.Equals(entity2)).ShouldBeFalse();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_new_instances_of_an_entity_are_created : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity1;

            static EntityWithAllPropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithAllPropertiesPartOfDomainSignature();
                entity2 = new EntityWithAllPropertiesPartOfDomainSignature();
            };

            It should_always_have_the_same_hash_code = () => entity1.GetHashCode().ShouldEqual(entity2.GetHashCode());
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_new_instances_of_an_entity_with_assigned_id_are_created_and_given_the_same_id : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity1;

            static EntityWithAllPropertiesPartOfDomainSignature entity2;

            Establish context = () =>
            {
                entity1 = new EntityWithAllPropertiesPartOfDomainSignature();
                entity1.SetIdTo(10);
                entity2 = new EntityWithAllPropertiesPartOfDomainSignature();
                entity2.SetIdTo(10);
            };

            It should_always_have_the_same_hash_code = () => entity1.GetHashCode().ShouldEqual(entity2.GetHashCode());
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_a_new_instance_of_an_entity_is_created : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity;

            Establish context = () => entity = new EntityWithAllPropertiesPartOfDomainSignature();

            It should_show_as_being_transient = () => entity.IsTransient().ShouldBeTrue();
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_a_new_instance_of_an_entity_that_has_no_domain_signature_properties_is_created_and_then_persisted : specification_for_entity_with_typed_id
        {
            static EntityWithNoDomainSignatureProperties entity;

            static int hashCodeWhenCreated;

            Establish context = () =>
            {
                entity = new EntityWithNoDomainSignatureProperties();
                hashCodeWhenCreated = entity.GetHashCode();
            };

            Because of = () => entity.SetIdTo(10);

            It should_show_as_not_being_transient = () => entity.IsTransient().ShouldBeFalse();

            It should_not_change_its_hash_code = () => entity.GetHashCode().ShouldEqual(hashCodeWhenCreated);
        }

        [Subject(typeof(EntityWithTypedId<>))]
        public class when_a_new_instance_of_an_entity_that_has_domain_signature_properties_is_created_and_then_persisted : specification_for_entity_with_typed_id
        {
            static EntityWithAllPropertiesPartOfDomainSignature entity;

            static int hashCodeWhenCreated;

            Establish context = () =>
            {
                entity = new EntityWithAllPropertiesPartOfDomainSignature();
                hashCodeWhenCreated = entity.GetHashCode();
            };

            Because of = () => entity.SetIdTo(10);

            It should_show_as_not_being_transient = () => entity.IsTransient().ShouldBeFalse();

            It should_not_change_its_hash_code = () => entity.GetHashCode().ShouldEqual(hashCodeWhenCreated);
        }    
    }
}